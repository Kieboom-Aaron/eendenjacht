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
        private State state;
        public InputHandler(Game game, InputContainer inputContainer) {
            this.inputContainer = inputContainer;
            this.game = game;
            state = game.stateFactory.create("notinroundstate");
        }

        public void onLeftMouseDown() {
            //TODO: If state == in round && player has bullets etc
            state.doAction(game);
        }

        public void setState(string id) {
            state = game.stateFactory.create(id);
        }

    }
}
