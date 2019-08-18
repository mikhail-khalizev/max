using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("099e67ae-f843-4119-8bd8-23317f79e906")]
        public void Method_100f_c3b0()
        {
            ii(0x100f_c3b0, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100f_c3b5, 5); calld(Definitions.sys_check_available_stack_size, 0x6_9998); /* call 0x10165d52 */
            ii(0x100f_c3ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c3bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c3bc, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c3bd, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c3be, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c3bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c3c1, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_c3c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c3ca, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_c3cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c3d0, 5); calld(Definitions.my_ctor_0x101b_4184, -0x8_58e5); /* call 0x10076af0 */
            ii(0x100f_c3d5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c3d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c3db, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100f_c3de, 5); calld(0x100f_c2bd, -0x126);             /* call 0x100fc2bd */
            ii(0x100f_c3e3, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100f_c3e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c3e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c3ec, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_c3ef, 5); calld(0x100f_c2bd, -0x137);             /* call 0x100fc2bd */
            ii(0x100f_c3f4, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100f_c3f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c3fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_c3fd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_c400, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100f_c404, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c407, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100f_c40b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_c40e, 2); jmpd(0x100f_c460, 0x50); goto l_0x100f_c460; /* jmp 0x100fc460 */
        l_0x100f_c410:
            ii(0x100f_c410, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c413, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x100f_c418, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c41b, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x100f_c421, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c424, 4); mov(memb_a32[ds, eax + 0x14], 0x9);     /* mov byte [eax+0x14], 0x9 */
            ii(0x100f_c428, 2); jmpd(0x100f_c487, 0x5d); goto l_0x100f_c487; /* jmp 0x100fc487 */
        l_0x100f_c42a:
            ii(0x100f_c42a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c42d, 5); mov(memw_a32[ds, eax], 0x1);            /* mov word [eax], 0x1 */
            ii(0x100f_c432, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c435, 6); mov(memw_a32[ds, eax + 0x2], 0x1);      /* mov word [eax+0x2], 0x1 */
            ii(0x100f_c43b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c43e, 4); mov(memb_a32[ds, eax + 0x14], 0xf);     /* mov byte [eax+0x14], 0xf */
            ii(0x100f_c442, 2); jmpd(0x100f_c487, 0x43); goto l_0x100f_c487; /* jmp 0x100fc487 */
        l_0x100f_c444:
            ii(0x100f_c444, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c447, 5); mov(memw_a32[ds, eax], 0x1);            /* mov word [eax], 0x1 */
            ii(0x100f_c44c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c44f, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x100f_c455, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c458, 4); mov(memb_a32[ds, eax + 0x14], 0x15);    /* mov byte [eax+0x14], 0x15 */
            ii(0x100f_c45c, 2); jmpd(0x100f_c487, 0x29); goto l_0x100f_c487; /* jmp 0x100fc487 */
        l_0x100f_c45e:
            ii(0x100f_c45e, 2); jmpd(0x100f_c487, 0x27); goto l_0x100f_c487; /* jmp 0x100fc487 */
        l_0x100f_c460:
            ii(0x100f_c460, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_c463, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_c466, 5); cmp(memw_a32[ss, ebp - 0x10], 0x40);    /* cmp word [ebp-0x10], 0x40 */
            ii(0x100f_c46b, 2); if(jbd(0x100f_c47e, 0x11)) goto l_0x100f_c47e; /* jb 0x100fc47e */
            ii(0x100f_c46d, 5); cmp(memw_a32[ss, ebp - 0x10], 0x40);    /* cmp word [ebp-0x10], 0x40 */
            ii(0x100f_c472, 2); if(jbed(0x100f_c444, -0x30)) goto l_0x100f_c444; /* jbe 0x100fc444 */
            ii(0x100f_c474, 6); cmp(memw_a32[ss, ebp - 0x10], 0x80);    /* cmp word [ebp-0x10], 0x80 */
            ii(0x100f_c47a, 2); if(jzd(0x100f_c410, -0x6c)) goto l_0x100f_c410; /* jz 0x100fc410 */
            ii(0x100f_c47c, 2); jmpd(0x100f_c45e, -0x20); goto l_0x100f_c45e; /* jmp 0x100fc45e */
        l_0x100f_c47e:
            ii(0x100f_c47e, 5); cmp(memw_a32[ss, ebp - 0x10], 0x20);    /* cmp word [ebp-0x10], 0x20 */
            ii(0x100f_c483, 2); if(jzd(0x100f_c42a, -0x5b)) goto l_0x100f_c42a; /* jz 0x100fc42a */
            ii(0x100f_c485, 2); jmpd(0x100f_c45e, -0x29); goto l_0x100f_c45e; /* jmp 0x100fc45e */
        l_0x100f_c487:
            ii(0x100f_c487, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x100f_c48c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c48f, 5); calld(0x100f_c548, 0xb4);               /* call 0x100fc548 */
            ii(0x100f_c494, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_c497, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x100f_c49c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c49f, 5); calld(0x100f_c548, 0xa4);               /* call 0x100fc548 */
            ii(0x100f_c4a4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c4a7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_c4aa, 5); calld(0x100f_c2ea, -0x1c5);             /* call 0x100fc2ea */
            ii(0x100f_c4af, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100f_c4b2, 3); add(ebx, 0x6);                          /* add ebx, 0x6 */
            ii(0x100f_c4b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c4b7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_c4b9, 5); calld(0x1010_29fc, 0x653e);             /* call 0x101029fc */
            ii(0x100f_c4be, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x100f_c4c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c4c6, 5); calld(0x100f_c548, 0x7d);               /* call 0x100fc548 */
            ii(0x100f_c4cb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_c4ce, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x100f_c4d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c4d6, 5); calld(0x100f_c548, 0x6d);               /* call 0x100fc548 */
            ii(0x100f_c4db, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c4de, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_c4e1, 5); calld(0x100f_c2ea, -0x1fc);             /* call 0x100fc2ea */
            ii(0x100f_c4e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c4e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c4eb, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_c4ee, 5); calld(0x1010_29fc, 0x6509);             /* call 0x101029fc */
            ii(0x100f_c4f3, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x100f_c4f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c4fb, 5); calld(0x100f_c548, 0x48);               /* call 0x100fc548 */
            ii(0x100f_c500, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_c503, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100f_c507, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_c50a, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x100f_c50d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c510, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_c515, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c517, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c51a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_c51c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_c51f, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x100f_c523, 5); mov(edx, 0xe);                          /* mov edx, 0xe */
            ii(0x100f_c528, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c52b, 5); calld(0x100f_c548, 0x18);               /* call 0x100fc548 */
            ii(0x100f_c530, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_c533, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x100f_c537, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c53a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_c53d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_c540, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c542, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c543, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c544, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c545, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c546, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c547, 1); retd(); return;                         /* ret */
        }
    }
}
