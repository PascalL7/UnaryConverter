<?php


$message = stream_get_line(STDIN, 100 + 1, "\n");

$msgLen= strlen($message);

        $bits = '';
        for ($i = 0; $i < $msgLen; $i++ ) {
            $bits .= sprintf("%07d", decbin(ord($message[$i])));
        }
        error_log("string in binary format: $bits\n\noutput:");
        $matches = [];
        $occurences = preg_match_all('/0+|1+/', $bits, $matches);
        $final = '';

        foreach ($matches as $match)
        {
            for ($i = 0; $i < count($match); $i++)
            {
                $final .= (substr($match[$i], 0, 1) === "1" ? " 0" : " 00");
                $final .= ' ' . str_pad('', strlen($match[$i]), '0');
            }
        }

        echo ltrim($final . PHP_EOL);


?>
