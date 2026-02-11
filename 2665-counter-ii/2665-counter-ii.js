/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
    let init1 = init;

    return {
        increment: () => {
            init1 += 1;
            return init1;
        },
        decrement: () => {
            init1 -= 1;
            return init1;
        },
        reset: () => {
            init1 = init;
            return init1;
        }
    };
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */