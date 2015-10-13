using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.containers;
using Duckhunt2.inputs;

namespace Duckhunt2 {
    class InputHandler {
        private InputContainer inputContainer;
        private Game game;
        public InputHandler(Game game, InputContainer inputContainer) {
            this.inputContainer = inputContainer;
            this.game = game;
        }

        public void onLeftMouseDown() {
            //TODO: If state == in round && player has bullets etc
            game.currentRound.state.doAction(game);
        }

    }
}
