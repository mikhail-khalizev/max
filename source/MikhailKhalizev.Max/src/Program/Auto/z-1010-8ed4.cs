using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8ed4-6b26077e")]
        public void Method_1010_8ed4()
        {
            ii(0x1010_8ed4, 5); push(0x78);                             /* push 0x78 */
            ii(0x1010_8ed9, 5); call(Definitions.sys_check_available_stack_size, 0x5_ce74); /* call 0x10165d52 */
            ii(0x1010_8ede, 1); push(ecx);                              /* push ecx */
            ii(0x1010_8edf, 1); push(esi);                              /* push esi */
            ii(0x1010_8ee0, 1); push(edi);                              /* push edi */
            ii(0x1010_8ee1, 1); push(ebp);                              /* push ebp */
            ii(0x1010_8ee2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8ee4, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1010_8eea, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_8eed, 3); mov(memb[ss, ebp - 8], dl);             /* mov [ebp-0x8], dl */
            ii(0x1010_8ef0, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1010_8ef3, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_8ef7, 3); imul(edx, eax, 0x18);                   /* imul edx, eax, 0x18 */
            ii(0x1010_8efa, 5); mov(eax, 0x101b_9a2c);                  /* mov eax, 0x101b9a2c */
            ii(0x1010_8eff, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_8f01, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_8f04, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_8f09, 5); call(/* sys */ 0x1016_a24c, 0x6_133e);  /* call 0x1016a24c */
            ii(0x1010_8f0e, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_8f12, 2); if(jl(0x1010_8f1a, 6)) goto l_0x1010_8f1a; /* jl 0x10108f1a */
            ii(0x1010_8f14, 4); cmp(memb[ss, ebp - 8], 7);              /* cmp byte [ebp-0x8], 0x7 */
            ii(0x1010_8f18, 2); if(jle(0x1010_8f1f, 5)) goto l_0x1010_8f1f; /* jle 0x10108f1f */
        l_0x1010_8f1a:
            ii(0x1010_8f1a, 5); jmp(0x1010_8fb8, 0x99); goto l_0x1010_8fb8; /* jmp 0x10108fb8 */
        l_0x1010_8f1f:
            ii(0x1010_8f1f, 5); movsx(ax, memb[ss, ebp - 8]);           /* movsx ax, byte [ebp-0x8] */
            ii(0x1010_8f24, 5); add(eax, 0x2d6);                        /* add eax, 0x2d6 */
            ii(0x1010_8f29, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1010_8f2c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_8f31, 5); call(Definitions.sys_new, 0x5_ceca);    /* call 0x10165e00 */
            ii(0x1010_8f36, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_8f39, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1010_8f3c, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1010_8f3f, 4); cmp(memd[ss, ebp - 28], 0);             /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_8f43, 2); if(jz(0x1010_8f7b, 0x36)) goto l_0x1010_8f7b; /* jz 0x10108f7b */
            ii(0x1010_8f45, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8f48, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_8f4a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_8f4d, 1); push(eax);                              /* push eax */
            ii(0x1010_8f4e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8f51, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1010_8f54, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8f57, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1010_8f5b, 1); inc(eax);                               /* inc eax */
            ii(0x1010_8f5c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_8f5f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8f62, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1010_8f65, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_8f68, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1010_8f6b, 5); call(Definitions.my_ctor_c17, -0x3_ab61); /* call 0x100ce40f */
            ii(0x1010_8f70, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1010_8f73, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1010_8f76, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1010_8f79, 2); jmp(0x1010_8f81, 6); goto l_0x1010_8f81; /* jmp 0x10108f81 */
        l_0x1010_8f7b:
            ii(0x1010_8f7b, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1010_8f7e, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
        l_0x1010_8f81:
            ii(0x1010_8f81, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_8f85, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_8f88, 3); mov(ecx, memd[ss, ebp - 12]);           /* mov ecx, [ebp-0xc] */
            ii(0x1010_8f8b, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1010_8f8d, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1010_8f90, 3); mov(memd[ds, ecx + 21], eax);           /* mov [ecx+0x15], eax */
            ii(0x1010_8f93, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x1010_8f98, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1010_8f9d, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1010_8fa1, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_8fa5, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_8fa8, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_8fab, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_8fae, 5); call(0x100c_ed1b, -0x3_a298);           /* call 0x100ced1b */
            ii(0x1010_8fb3, 5); jmp(0x1010_90f7, 0x13f); goto l_0x1010_90f7; /* jmp 0x101090f7 */
        l_0x1010_8fb8:
            ii(0x1010_8fb8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8fbb, 5); cmp(memw[ds, eax + 8], -1 /* 0xff */);  /* cmp word [eax+0x8], 0xffff */
            ii(0x1010_8fc0, 6); if(jnz(0x1010_903d, 0x77)) goto l_0x1010_903d; /* jnz 0x1010903d */
            ii(0x1010_8fc6, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_8fcb, 5); call(Definitions.sys_new, 0x5_ce30);    /* call 0x10165e00 */
            ii(0x1010_8fd0, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1010_8fd3, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1010_8fd6, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1010_8fd9, 4); cmp(memd[ss, ebp - 44], 0);             /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1010_8fdd, 2); if(jz(0x1010_9020, 0x41)) goto l_0x1010_9020; /* jz 0x10109020 */
            ii(0x1010_8fdf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8fe2, 4); mov(ax, memw[ds, eax + 6]);             /* mov ax, [eax+0x6] */
            ii(0x1010_8fe6, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1010_8fe9, 4); sub(ax, memw[ds, edx + 2]);             /* sub ax, [edx+0x2] */
            ii(0x1010_8fed, 1); cwde();                                 /* cwde */
            ii(0x1010_8fee, 1); push(eax);                              /* push eax */
            ii(0x1010_8fef, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_8ff2, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1010_8ff6, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1010_8ff9, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1010_8ffc, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_8fff, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9002, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1010_9004, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_9007, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_900a, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1010_900d, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1010_9010, 5); call(0x100c_e39d, -0x3_ac78);           /* call 0x100ce39d */
            ii(0x1010_9015, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1010_9018, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1010_901b, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1010_901e, 2); jmp(0x1010_9026, 6); goto l_0x1010_9026; /* jmp 0x10109026 */
        l_0x1010_9020:
            ii(0x1010_9020, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1010_9023, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
        l_0x1010_9026:
            ii(0x1010_9026, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_902a, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_902d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_9030, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_9032, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1010_9035, 3); mov(memd[ds, edx + 21], eax);           /* mov [edx+0x15], eax */
            ii(0x1010_9038, 5); jmp(0x1010_90f7, 0xba); goto l_0x1010_90f7; /* jmp 0x101090f7 */
        l_0x1010_903d:
            ii(0x1010_903d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_9042, 5); call(Definitions.sys_new, 0x5_cdb9);    /* call 0x10165e00 */
            ii(0x1010_9047, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x1010_904a, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1010_904d, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x1010_9050, 4); cmp(memd[ss, ebp - 60], 0);             /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_9054, 2); if(jz(0x1010_908c, 0x36)) goto l_0x1010_908c; /* jz 0x1010908c */
            ii(0x1010_9056, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9059, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_905b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_905e, 1); push(eax);                              /* push eax */
            ii(0x1010_905f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9062, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1010_9065, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9068, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1010_906c, 1); inc(eax);                               /* inc eax */
            ii(0x1010_906d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_9070, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9073, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1010_9076, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_9079, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1010_907c, 5); call(Definitions.my_ctor_c17, -0x3_ac72); /* call 0x100ce40f */
            ii(0x1010_9081, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x1010_9084, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x1010_9087, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x1010_908a, 2); jmp(0x1010_9092, 6); goto l_0x1010_9092; /* jmp 0x10109092 */
        l_0x1010_908c:
            ii(0x1010_908c, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1010_908f, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
        l_0x1010_9092:
            ii(0x1010_9092, 4); movsx(edx, memb[ss, ebp - 8]);          /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_9096, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1010_9099, 3); add(edx, memd[ss, ebp - 12]);           /* add edx, [ebp-0xc] */
            ii(0x1010_909c, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x1010_909f, 3); mov(memd[ds, edx + 21], eax);           /* mov [edx+0x15], eax */
            ii(0x1010_90a2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_90a5, 4); cmp(memd[ds, eax + 10], 0);             /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_90a9, 2); if(jz(0x1010_90f7, 0x4c)) goto l_0x1010_90f7; /* jz 0x101090f7 */
            ii(0x1010_90ab, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x1010_90ae, 5); call(0x100d_5224, -0x3_3e8f);           /* call 0x100d5224 */
            ii(0x1010_90b3, 1); push(eax);                              /* push eax */
            ii(0x1010_90b4, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1010_90b7, 5); call(0x100d_5250, -0x3_3e6c);           /* call 0x100d5250 */
            ii(0x1010_90bc, 1); push(eax);                              /* push eax */
            ii(0x1010_90bd, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1010_90c0, 5); call(0x100d_527c, -0x3_3e49);           /* call 0x100d527c */
            ii(0x1010_90c5, 1); push(eax);                              /* push eax */
            ii(0x1010_90c6, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1010_90c9, 5); call(0x100d_52a8, -0x3_3e26);           /* call 0x100d52a8 */
            ii(0x1010_90ce, 1); push(eax);                              /* push eax */
            ii(0x1010_90cf, 5); call(0x100d_52d4, -0x3_3e00);           /* call 0x100d52d4 */
            ii(0x1010_90d4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_90d7, 5); call(0x100d_52f8, -0x3_3de4);           /* call 0x100d52f8 */
            ii(0x1010_90dc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_90df, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_90e2, 3); mov(edx, memd[ds, eax + 10]);           /* mov edx, [eax+0xa] */
            ii(0x1010_90e5, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_90e9, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_90ec, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_90ef, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_90f2, 5); call(0x100c_ef64, -0x3_a193);           /* call 0x100cef64 */
        l_0x1010_90f7:
            ii(0x1010_90f7, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_90fb, 2); if(jz(0x1010_9132, 0x35)) goto l_0x1010_9132; /* jz 0x10109132 */
            ii(0x1010_90fd, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1010_9102, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9106, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_9109, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_910c, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_910f, 5); call(0x100d_5194, -0x3_3f80);           /* call 0x100d5194 */
            ii(0x1010_9114, 4); movsx(edx, memb[ss, ebp - 8]);          /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_9118, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_911e, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9122, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_9125, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_9128, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_912b, 5); call(0x100d_5164, -0x3_3fcc);           /* call 0x100d5164 */
            ii(0x1010_9130, 2); jmp(0x1010_917e, 0x4c); goto l_0x1010_917e; /* jmp 0x1010917e */
        l_0x1010_9132:
            ii(0x1010_9132, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_9134, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9138, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_913b, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_913e, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_9141, 5); call(0x100d_5194, -0x3_3fb2);           /* call 0x100d5194 */
            ii(0x1010_9146, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_914a, 6); lea(edx, memd[ds, eax + 1000]);         /* lea edx, [eax+0x3e8] */
            ii(0x1010_9150, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9154, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_9157, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_915a, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_915d, 5); call(0x100d_5134, -0x3_402e);           /* call 0x100d5134 */
            ii(0x1010_9162, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9166, 6); lea(edx, memd[ds, eax + 28672]);        /* lea edx, [eax+0x7000] */
            ii(0x1010_916c, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_9170, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_9173, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_9176, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_9179, 5); call(0x100d_5164, -0x3_401a);           /* call 0x100d5164 */
        l_0x1010_917e:
            ii(0x1010_917e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_9181, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x1010_9184, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_9187, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_918b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_918e, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_9191, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_9194, 5); call(0x100d_50d4, -0x3_40c5);           /* call 0x100d50d4 */
            ii(0x1010_9199, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_919c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_919e, 3); mov(edx, memd[ds, eax + 18]);           /* mov edx, [eax+0x12] */
            ii(0x1010_91a1, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_91a5, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_91a8, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_91ab, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1010_91ae, 5); call(0x100c_f85c, -0x3_9957);           /* call 0x100cf85c */
            ii(0x1010_91b3, 4); movsx(edx, memb[ss, ebp - 8]);          /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_91b7, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_91bb, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_91be, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1010_91c1, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_91c7, 3); mov(memd[ds, eax + 69], edx);           /* mov [eax+0x45], edx */
            ii(0x1010_91ca, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_91ce, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_91d1, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_91d4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_91d6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_91d9, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x1010_91dc, 3); mov(memd[ds, edx + 73], eax);           /* mov [edx+0x49], eax */
            ii(0x1010_91df, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_91e3, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_91e6, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_91e9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_91eb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_91ee, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1010_91f1, 3); mov(memd[ds, edx + 77], eax);           /* mov [edx+0x4d], eax */
            ii(0x1010_91f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_91f6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_91f7, 1); pop(edi);                               /* pop edi */
            ii(0x1010_91f8, 1); pop(esi);                               /* pop esi */
            ii(0x1010_91f9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_91fa, 1); ret();                                  /* ret */
        }
    }
}
