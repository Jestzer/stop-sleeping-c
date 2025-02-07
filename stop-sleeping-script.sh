#!/bin/bash
while true; do
    CURRENT_DATE_TIME=$(date '+%Y-%m-%d %H:%M:%S')
    echo "$CURRENT_DATE_TIME" >> "/run/media/james/HDD/timer.txt"
    sleep 60
done