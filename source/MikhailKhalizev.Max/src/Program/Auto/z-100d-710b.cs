using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_710b-f698b133")]
        public void Method_100d_710b()
        {
            ii(0x100d_710b, 5); push(0x74);                             /* push 0x74 */
            ii(0x100d_7110, 5); call(Definitions.sys_check_available_stack_size, 0x8_ec3d); /* call 0x10165d52 */
            ii(0x100d_7115, 1); push(ebx);                              /* push ebx */
            ii(0x100d_7116, 1); push(ecx);                              /* push ecx */
            ii(0x100d_7117, 1); push(edx);                              /* push edx */
            ii(0x100d_7118, 1); push(esi);                              /* push esi */
            ii(0x100d_7119, 1); push(edi);                              /* push edi */
            ii(0x100d_711a, 1); push(ebp);                              /* push ebp */
            ii(0x100d_711b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_711d, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100d_7123, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_7126, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x100d_7129, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_712c, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x100d_712f, 5); call(0x100d_6a11, -0x723);              /* call 0x100d6a11 */
            ii(0x100d_7134, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7137, 4); cmp(memd[ds, eax + 10], 0);             /* cmp dword [eax+0xa], 0x0 */
            ii(0x100d_713b, 2); if(jz(0x100d_714b, 0xe)) goto l_0x100d_714b; /* jz 0x100d714b */
            ii(0x100d_713d, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x100d_7140, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7143, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_7146, 5); call(0x100d_7f6c, 0xe21);               /* call 0x100d7f6c */
        l_0x100d_714b:
            ii(0x100d_714b, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x100d_714e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7151, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7154, 5); call(0x100d_7f6c, 0xe13);               /* call 0x100d7f6c */
            ii(0x100d_7159, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_715c, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100d_715f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_7162, 4); sub(ax, memw[ds, edx + 2]);             /* sub ax, [edx+0x2] */
            ii(0x100d_7166, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_7169, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_716c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_716f, 5); call(0x100d_4ebc, -0x22b8);             /* call 0x100d4ebc */
            ii(0x100d_7174, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7177, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100d_717b, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_717e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7181, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7184, 5); call(0x100d_4ef0, -0x2299);             /* call 0x100d4ef0 */
            ii(0x100d_7189, 1); cwde();                                 /* cwde */
            ii(0x100d_718a, 3); add(eax, memd[ss, ebp - 14]);           /* add eax, [ebp-0xe] */
            ii(0x100d_718d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_718f, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100d_7192, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7195, 4); cmp(memb[ds, eax + 38], 0);             /* cmp byte [eax+0x26], 0x0 */
            ii(0x100d_7199, 6); if(jz(0x100d_7221, 0x82)) goto l_0x100d_7221; /* jz 0x100d7221 */
            ii(0x100d_719f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_71a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_71a5, 2); if(jle(0x100d_71d9, 0x32)) goto l_0x100d_71d9; /* jle 0x100d71d9 */
            ii(0x100d_71a7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_71aa, 3); mov(ebx, memd[ds, edx + 2]);            /* mov ebx, [edx+0x2] */
            ii(0x100d_71ad, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_71b0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_71b3, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x100d_71b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_71b8, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100d_71ba, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_71bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_71bf, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_71c2, 5); call(0x100d_4f24, -0x22a3);             /* call 0x100d4f24 */
            ii(0x100d_71c7, 1); cwde();                                 /* cwde */
            ii(0x100d_71c8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_71cb, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_71cf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_71d1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_71d4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_71d6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100d_71d9:
            ii(0x100d_71d9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_71dc, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_71df, 5); call(0x100d_4f24, -0x22c0);             /* call 0x100d4f24 */
            ii(0x100d_71e4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_71e7, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_71eb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_71ed, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100d_71f1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_71f4, 3); add(memd[ss, ebp - 40], eax);           /* add [ebp-0x28], eax */
            ii(0x100d_71f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_71fa, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100d_71fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7200, 1); push(eax);                              /* push eax */
            ii(0x100d_7201, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7204, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7207, 5); call(0x100d_4f58, -0x22b4);             /* call 0x100d4f58 */
            ii(0x100d_720c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_720f, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_7213, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100d_7217, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_721a, 5); call(0x100d_701e, -0x201);              /* call 0x100d701e */
            ii(0x100d_721f, 2); jmp(0x100d_7283, 0x62); goto l_0x100d_7283; /* jmp 0x100d7283 */
        l_0x100d_7221:
            ii(0x100d_7221, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_7225, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7227, 2); if(jle(0x100d_725b, 0x32)) goto l_0x100d_725b; /* jle 0x100d725b */
            ii(0x100d_7229, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_722c, 3); mov(ebx, memd[ds, edx + 2]);            /* mov ebx, [edx+0x2] */
            ii(0x100d_722f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_7232, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_7235, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x100d_7237, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_723a, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100d_723c, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_723e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7241, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7244, 5); call(0x100d_4f58, -0x22f1);             /* call 0x100d4f58 */
            ii(0x100d_7249, 1); cwde();                                 /* cwde */
            ii(0x100d_724a, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_724d, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_7251, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7253, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_7256, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_7258, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100d_725b:
            ii(0x100d_725b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_725e, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100d_7261, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7264, 1); push(eax);                              /* push eax */
            ii(0x100d_7265, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x100d_7269, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_726c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_726f, 5); call(0x100d_4f24, -0x2350);             /* call 0x100d4f24 */
            ii(0x100d_7274, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_7277, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100d_727b, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_727e, 5); call(0x1014_2d60, 0x6_badd);            /* call 0x10142d60 */
        l_0x100d_7283:
            ii(0x100d_7283, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7286, 5); cmp(memw[ds, eax + 36], 0);             /* cmp word [eax+0x24], 0x0 */
            ii(0x100d_728b, 6); if(jz(0x100d_7350, 0xbf)) goto l_0x100d_7350; /* jz 0x100d7350 */
            ii(0x100d_7291, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7294, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100d_7297, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_729a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_729d, 3); mov(eax, memd[ds, eax + 34]);           /* mov eax, [eax+0x22] */
            ii(0x100d_72a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_72a3, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_72a6, 1); push(eax);                              /* push eax */
            ii(0x100d_72a7, 5); mov(eax, StringDefinitions.I13);        /* mov eax, 0x101a17f1 */
            ii(0x100d_72ac, 1); push(eax);                              /* push eax */
            ii(0x100d_72ad, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100d_72b0, 1); push(eax);                              /* push eax */
            ii(0x100d_72b1, 5); call(Definitions.sys_sprintf, 0x8_ec4b); /* call 0x10165f01 */
            ii(0x100d_72b6, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100d_72b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_72bc, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_72bf, 5); call(0x100d_4ebc, -0x2408);             /* call 0x100d4ebc */
            ii(0x100d_72c4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_72c7, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100d_72cb, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_72ce, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_72d1, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_72d4, 5); call(0x100d_4ef0, -0x23e9);             /* call 0x100d4ef0 */
            ii(0x100d_72d9, 1); cwde();                                 /* cwde */
            ii(0x100d_72da, 3); add(eax, memd[ss, ebp - 14]);           /* add eax, [ebp-0xe] */
            ii(0x100d_72dd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_72df, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100d_72e2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_72e5, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_72e8, 5); call(0x100d_4f24, -0x23c9);             /* call 0x100d4f24 */
            ii(0x100d_72ed, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_72f0, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100d_72f6, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_72f8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_72fa, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_72fd, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_72ff, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100d_7301, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100d_7305, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_7308, 3); add(memd[ss, ebp - 40], eax);           /* add [ebp-0x28], eax */
            ii(0x100d_730b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_730e, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_7311, 5); call(0x100d_4f58, -0x23be);             /* call 0x100d4f58 */
            ii(0x100d_7316, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7319, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100d_731c, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100d_7322, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_7324, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7326, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_7329, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_732b, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100d_732d, 3); add(memd[ss, ebp - 40], eax);           /* add [ebp-0x28], eax */
            ii(0x100d_7330, 5); push(0xff);                             /* push 0xff */
            ii(0x100d_7335, 4); movsx(ecx, memw[ss, ebp - 20]);         /* movsx ecx, word [ebp-0x14] */
            ii(0x100d_7339, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100d_733c, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100d_7342, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_7344, 3); lea(edx, memd[ss, ebp - 60]);           /* lea edx, [ebp-0x3c] */
            ii(0x100d_7347, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_734a, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
        l_0x100d_7350:
            ii(0x100d_7350, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7353, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7356, 5); call(0x100d_4ebc, -0x249f);             /* call 0x100d4ebc */
            ii(0x100d_735b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_735d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7360, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7363, 5); call(0x100d_4f24, -0x2444);             /* call 0x100d4f24 */
            ii(0x100d_7368, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_736a, 1); cwde();                                 /* cwde */
            ii(0x100d_736b, 1); push(eax);                              /* push eax */
            ii(0x100d_736c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_736f, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7372, 5); call(0x100d_4ef0, -0x2487);             /* call 0x100d4ef0 */
            ii(0x100d_7377, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_7379, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_737c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_737f, 5); call(0x100d_4f58, -0x242c);             /* call 0x100d4f58 */
            ii(0x100d_7384, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_7386, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_7389, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_738c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_738f, 5); call(0x100d_4ebc, -0x24d8);             /* call 0x100d4ebc */
            ii(0x100d_7394, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_7397, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_739a, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_739d, 5); call(0x100d_4ef0, -0x24b2);             /* call 0x100d4ef0 */
            ii(0x100d_73a2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_73a5, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100d_73a8, 5); call(0x1008_b148, -0x4_c265);           /* call 0x1008b148 */
            ii(0x100d_73ad, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x100d_73b0, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x100d_73b3, 5); call(Definitions.sys_display_draw_1, 0x9_00f0); /* call 0x101674a8 */
            ii(0x100d_73b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_73bb, 4); cmp(memd[ds, eax + 10], 0);             /* cmp dword [eax+0xa], 0x0 */
            ii(0x100d_73bf, 2); if(jz(0x100d_7428, 0x67)) goto l_0x100d_7428; /* jz 0x100d7428 */
            ii(0x100d_73c1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_73c4, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_73c7, 5); call(0x100d_4ef0, -0x24dc);             /* call 0x100d4ef0 */
            ii(0x100d_73cc, 1); cwde();                                 /* cwde */
            ii(0x100d_73cd, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100d_73d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_73d3, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_73d6, 5); call(0x100d_4ebc, -0x251f);             /* call 0x100d4ebc */
            ii(0x100d_73db, 1); cwde();                                 /* cwde */
            ii(0x100d_73dc, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x100d_73df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_73e2, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_73e5, 5); call(0x100d_4ef0, -0x24fa);             /* call 0x100d4ef0 */
            ii(0x100d_73ea, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_73ed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_73f0, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_73f3, 5); call(0x100d_4f58, -0x24a0);             /* call 0x100d4f58 */
            ii(0x100d_73f8, 1); cwde();                                 /* cwde */
            ii(0x100d_73f9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_73fb, 3); mov(memd[ss, ebp - 68], edx);           /* mov [ebp-0x44], edx */
            ii(0x100d_73fe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7401, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_7404, 5); call(0x100d_4ebc, -0x254d);             /* call 0x100d4ebc */
            ii(0x100d_7409, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_740c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_740f, 3); mov(eax, memd[ds, eax + 10]);           /* mov eax, [eax+0xa] */
            ii(0x100d_7412, 5); call(0x100d_4f24, -0x24f3);             /* call 0x100d4f24 */
            ii(0x100d_7417, 1); cwde();                                 /* cwde */
            ii(0x100d_7418, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_741a, 3); mov(memd[ss, ebp - 64], edx);           /* mov [ebp-0x40], edx */
            ii(0x100d_741d, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x100d_7420, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x100d_7423, 5); call(Definitions.sys_display_draw_1, 0x9_0080); /* call 0x101674a8 */
        l_0x100d_7428:
            ii(0x100d_7428, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_742a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_742b, 1); pop(edi);                               /* pop edi */
            ii(0x100d_742c, 1); pop(esi);                               /* pop esi */
            ii(0x100d_742d, 1); pop(edx);                               /* pop edx */
            ii(0x100d_742e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_742f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_7430, 1); ret();                                  /* ret */
        }
    }
}
