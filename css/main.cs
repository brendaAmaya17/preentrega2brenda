/* Error: Undefined variable.
 *    ,
 * 20 |                     color: $color_1;
 *    |                            ^^^^^^^^
 *    '
 *   scss\componentes\_header.scss 20:13  @import
 *   scss\main.scss 6:9                   root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Undefined variable.\a    \2577 \a 20 \2502                      color: $color_1;\d\a    \2502                             ^^^^^^^^\a    \2575 \a   scss\\componentes\\_header.scss 20:13  @import\a   scss\\main.scss 6:9                   root stylesheet";
}
