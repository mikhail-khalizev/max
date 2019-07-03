enum class file_flags : int
{
    rdonly = O_RDONLY,
    wronly = O_WRONLY,
    rdwr = O_RDWR,

    /* optional: */

    creat = O_CREAT,
    creat_excl = O_CREAT | O_EXCL,
    trunc = O_TRUNC,
    noctty = O_NOCTTY,

    append = O_APPEND,
    async = O_ASYNC,
    nocloexec = O_CLOEXEC,
    direct = O_DIRECT,
    directory = O_DIRECTORY,
    largefile = O_LARGEFILE,
    noatime = O_NOATIME,
    nofollow = O_NOFOLLOW,
    nonblock = O_NONBLOCK,
    ndelay = nonblock,
    sync = O_SYNC
};

enum class file_perm : detail::mode_t
{
    rwx_u = S_IRWXU,
    r_usr = S_IRUSR,
    w_usr = S_IWUSR,
    x_usr = S_IXUSR,

    rwx_g = S_IRWXG,
    r_grp = S_IRGRP,
    w_grp = S_IWGRP,
    x_grp = S_IXGRP,

    rwx_o = S_IRWXO,
    r_oth = S_IROTH,
    w_oth = S_IWOTH,
    x_oth = S_IXOTH,

    set_uid = S_ISUID,
    set_gid = S_ISGID,
    sticky = S_ISVTX
};

enum class file_type : detail::mode_t
{
    fifo = S_IFIFO,
    socket = S_IFSOCK,
    symlink = S_IFLNK,
    regular = S_IFREG,
    directory = S_IFDIR,
    char_device = S_IFCHR,
    block_device = S_IFBLK
};

namespace detail {
    constexpr mode_t file_type_mask = S_IFMT;
} /* namespace detail */

enum class map_prot : int
{
    none = PROT_NONE,
    read = PROT_READ,
    write = PROT_WRITE,
    exec = PROT_EXEC
};

enum class map_type : int
{
    shared = MAP_SHARED,
    private_ = MAP_PRIVATE,

    fixed = MAP_FIXED,
    anonymous = MAP_ANONYMOUS,
    locked = MAP_LOCKED,
    populate = MAP_POPULATE,
    nonblock = MAP_NONBLOCK,
    noreserve = MAP_NORESERVE,
    hugetlb = MAP_HUGETLB,
    growsdown = MAP_GROWSDOWN,
    stack = MAP_STACK
};

enum class clock_id : detail::clockid_t
{
    realtime = CLOCK_REALTIME,
    monotonic = CLOCK_MONOTONIC,
    process_cputime_id = CLOCK_PROCESS_CPUTIME_ID,
    thread_cputime_id = CLOCK_THREAD_CPUTIME_ID,
    monotonic_raw = CLOCK_MONOTONIC_RAW,
    realtime_coarse = CLOCK_REALTIME_COARSE,
    monotonic_coarse = CLOCK_MONOTONIC_COARSE,
    boottime = CLOCK_BOOTTIME,
    realtime_alarm = CLOCK_REALTIME_ALARM,
    boottime_alarm = CLOCK_BOOTTIME_ALARM
};
