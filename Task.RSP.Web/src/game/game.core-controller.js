class GameCoreController {

    constructor(gamePlayService) {
        this.playService = gamePlayService;
        this.player1Choice = null;
        this.player2Choice = null;
        this.availableChoices = [];
    }

    select(choice) {
        this.player1Choice = choice;
        this.player2Choice = null;
        this.playService.getComputerChoice()
            .then(
            /*success*/
            (response) => {
                if (response.data) {
                    let data = +response.data;
                    this.player2Choice = (data === 1 ? "Rock" : data === 2 ? "Scissor" : data === 3 ? "Paper" : "");
                    this.throw();
                }
            },
            /*fail*/
            (error) => {
                console.log('e', error);
            });
    }

    throw() {
        let input1 = (this.player1Choice === "Rock" ? 1 : this.player1Choice === "Scissor" ? 2 : this.player1Choice === "Paper" ? 3 : 0),
            input2 = (this.player2Choice === "Rock" ? 1 : this.player2Choice === "Scissor" ? 2 : this.player2Choice === "Paper" ? 3 : 0);

        this.playService.play(input1, input2)
            .then(
            /*success*/
            (response) => {
                if (response.data) {
                    [this.gameResultMessage, this.player1Score, this.player2Score] = [response.data.gameResultMessage, response.data.player1Score, response.data.player2Score];
                }
            },
            /*fail*/
            (error) => {
                console.log('e', error);
            });
    }
}

GameCoreController.$inject = ["gamePlayService"];
module.exports = GameCoreController;

