using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a57f-9aa92cb1")]
        public void Method_1009_a57f()
        {
            ii(0x1009_a57f, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1009_a584, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b7c9); /* call 0x10165d52 */
            ii(0x1009_a589, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a58a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a58b, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a58c, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a58d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a58e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a590, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1009_a596, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_a599, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_a59c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_a5a1, 5); calld(0x1007_6338, -0x2_426e);          /* call 0x10076338 */
            ii(0x1009_a5a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a5a8, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a5ab, 5); calld(0x1007_64b8, -0x2_40f8);          /* call 0x100764b8 */
            ii(0x1009_a5b0, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1009_a5b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a5ba, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1009_a5bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_a5c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_a5c4, 2); if(jnzd(0x1009_a5d9, 0x13)) goto l_0x1009_a5d9; /* jnz 0x1009a5d9 */
            ii(0x1009_a5c6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_a5ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a5cc, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a5cf, 5); calld(0x1007_5f6c, -0x2_4668);          /* call 0x10075f6c */
            ii(0x1009_a5d4, 5); jmpd(0x1009_a86c, 0x293); goto l_0x1009_a86c; /* jmp 0x1009a86c */
        l_0x1009_a5d9:
            ii(0x1009_a5d9, 2); jmpd(0x1009_a5e3, 0x8); goto l_0x1009_a5e3; /* jmp 0x1009a5e3 */
        l_0x1009_a5db:
            ii(0x1009_a5db, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a5de, 5); calld(0x1007_6bf8, -0x2_39eb);          /* call 0x10076bf8 */
        l_0x1009_a5e3:
            ii(0x1009_a5e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a5e5, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a5e8, 5); calld(0x1013_ad71, 0xa_0784);           /* call 0x1013ad71 */
            ii(0x1009_a5ed, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a5ef, 6); if(jzd(0x1009_a7c5, 0x1d0)) goto l_0x1009_a7c5; /* jz 0x1009a7c5 */
            ii(0x1009_a5f5, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a5f8, 5); calld(0x1007_63a0, -0x2_425d);          /* call 0x100763a0 */
            ii(0x1009_a5fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a5ff, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_a602, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a605, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_a608, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a60b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_a60d, 2); if(jnzd(0x1009_a630, 0x21)) goto l_0x1009_a630; /* jnz 0x1009a630 */
            ii(0x1009_a60f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a612, 5); calld(0x1007_63a0, -0x2_4277);          /* call 0x100763a0 */
            ii(0x1009_a617, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a619, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a61c, 5); calld(0x1007_63a0, -0x2_4281);          /* call 0x100763a0 */
            ii(0x1009_a621, 5); calld(0x1007_623c, -0x2_43ea);          /* call 0x1007623c */
            ii(0x1009_a626, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1009_a62a, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x1009_a62e, 2); if(jld(0x1009_a632, 0x2)) goto l_0x1009_a632; /* jl 0x1009a632 */
        l_0x1009_a630:
            ii(0x1009_a630, 2); jmpd(0x1009_a646, 0x14); goto l_0x1009_a646; /* jmp 0x1009a646 */
        l_0x1009_a632:
            ii(0x1009_a632, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a635, 5); calld(0x1007_63a0, -0x2_429a);          /* call 0x100763a0 */
            ii(0x1009_a63a, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1009_a63d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_a642, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_a644, 2); if(jgd(0x1009_a648, 0x2)) goto l_0x1009_a648; /* jg 0x1009a648 */
        l_0x1009_a646:
            ii(0x1009_a646, 2); jmpd(0x1009_a662, 0x1a); goto l_0x1009_a662; /* jmp 0x1009a662 */
        l_0x1009_a648:
            ii(0x1009_a648, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a64b, 5); calld(0x1007_63a0, -0x2_42b0);          /* call 0x100763a0 */
            ii(0x1009_a650, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_a653, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a656, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_a659, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1009_a660, 2); if(jzd(0x1009_a667, 0x5)) goto l_0x1009_a667; /* jz 0x1009a667 */
        l_0x1009_a662:
            ii(0x1009_a662, 5); jmpd(0x1009_a7c0, 0x159); goto l_0x1009_a7c0; /* jmp 0x1009a7c0 */
        l_0x1009_a667:
            ii(0x1009_a667, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a66a, 5); calld(0x1007_63a0, -0x2_42cf);          /* call 0x100763a0 */
            ii(0x1009_a66f, 5); calld(0x1007_6204, -0x2_4470);          /* call 0x10076204 */
            ii(0x1009_a674, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_a677, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_a67c, 5); calld(0x1007_6338, -0x2_4349);          /* call 0x10076338 */
            ii(0x1009_a681, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a683, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a686, 5); calld(0x1007_64b8, -0x2_41d3);          /* call 0x100764b8 */
            ii(0x1009_a68b, 2); jmpd(0x1009_a695, 0x8); goto l_0x1009_a695; /* jmp 0x1009a695 */
        l_0x1009_a68d:
            ii(0x1009_a68d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a690, 5); calld(0x1007_6bf8, -0x2_3a9d);          /* call 0x10076bf8 */
        l_0x1009_a695:
            ii(0x1009_a695, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a697, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a69a, 5); calld(0x1013_ad71, 0xa_06d2);           /* call 0x1013ad71 */
            ii(0x1009_a69f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a6a1, 6); if(jzd(0x1009_a7b6, 0x10f)) goto l_0x1009_a7b6; /* jz 0x1009a7b6 */
            ii(0x1009_a6a7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a6aa, 5); calld(0x1007_63a0, -0x2_430f);          /* call 0x100763a0 */
            ii(0x1009_a6af, 5); calld(0x1007_6204, -0x2_44b0);          /* call 0x10076204 */
            ii(0x1009_a6b4, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x1009_a6b7, 6); if(jnzd(0x1009_a7b1, 0xf4)) goto l_0x1009_a7b1; /* jnz 0x1009a7b1 */
            ii(0x1009_a6bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a6c0, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1009_a6c3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_a6c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a6c9, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_a6cc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_a6cf, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a6d2, 5); calld(0x1007_636c, -0x2_436b);          /* call 0x1007636c */
            ii(0x1009_a6d7, 5); calld(0x100a_30a2, 0x89c6);             /* call 0x100a30a2 */
            ii(0x1009_a6dc, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a6de, 6); if(jzd(0x1009_a77e, 0x9a)) goto l_0x1009_a77e; /* jz 0x1009a77e */
            ii(0x1009_a6e4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_a6e6, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1009_a6eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_a6ed, 2); if(jnzd(0x1009_a704, 0x15)) goto l_0x1009_a704; /* jnz 0x1009a704 */
            ii(0x1009_a6ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a6f2, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_a6f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a6f8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a6fa, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1009_a700, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_a702, 2); if(jnzd(0x1009_a761, 0x5d)) goto l_0x1009_a761; /* jnz 0x1009a761 */
        l_0x1009_a704:
            ii(0x1009_a704, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a707, 5); calld(0x1007_63a0, -0x2_436c);          /* call 0x100763a0 */
            ii(0x1009_a70c, 5); calld(0x1007_623c, -0x2_44d5);          /* call 0x1007623c */
            ii(0x1009_a711, 3); mov(ebx, memd_a32[ds, eax + 0x17]);     /* mov ebx, [eax+0x17] */
            ii(0x1009_a714, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_a717, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a71a, 5); calld(0x1007_63a0, -0x2_437f);          /* call 0x100763a0 */
            ii(0x1009_a71f, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x1009_a722, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_a725, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1009_a727, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_a729, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a72c, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1009_a72f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a732, 5); calld(Definitions.my_min, -0x1_0fb3);   /* call 0x10089784 */
            ii(0x1009_a737, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a739, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a73c, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1009_a740, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a743, 5); calld(0x1007_63d4, -0x2_4374);          /* call 0x100763d4 */
            ii(0x1009_a748, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a74a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a74d, 5); calld(0x1008_a998, -0xfdba);            /* call 0x1008a998 */
            ii(0x1009_a752, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_a754, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1009_a759, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a75c, 5); calld(0x1016_3053, 0xc_88f2);           /* call 0x10163053 */
        l_0x1009_a761:
            ii(0x1009_a761, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_a765, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a767, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a76a, 5); calld(0x1007_5f6c, -0x2_4803);          /* call 0x10075f6c */
            ii(0x1009_a76f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a771, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a774, 5); calld(0x1007_5f6c, -0x2_480d);          /* call 0x10075f6c */
            ii(0x1009_a779, 5); jmpd(0x1009_a86c, 0xee); goto l_0x1009_a86c; /* jmp 0x1009a86c */
        l_0x1009_a77e:
            ii(0x1009_a77e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a781, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a784, 5); calld(0x1007_636c, -0x2_441d);          /* call 0x1007636c */
            ii(0x1009_a789, 5); calld(0x100a_601a, 0xb88c);             /* call 0x100a601a */
            ii(0x1009_a78e, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_a791, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_a795, 2); if(jzd(0x1009_a7a0, 0x9)) goto l_0x1009_a7a0; /* jz 0x1009a7a0 */
            ii(0x1009_a797, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_a79a, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1009_a79e, 2); if(jged(0x1009_a7b1, 0x11)) goto l_0x1009_a7b1; /* jge 0x1009a7b1 */
        l_0x1009_a7a0:
            ii(0x1009_a7a0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_a7a3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_a7a6, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a7a9, 5); calld(0x1007_6408, -0x2_43a6);          /* call 0x10076408 */
            ii(0x1009_a7ae, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1009_a7b1:
            ii(0x1009_a7b1, 5); jmpd(0x1009_a68d, -0x129); goto l_0x1009_a68d; /* jmp 0x1009a68d */
        l_0x1009_a7b6:
            ii(0x1009_a7b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a7b8, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_a7bb, 5); calld(0x1007_5f6c, -0x2_4854);          /* call 0x10075f6c */
        l_0x1009_a7c0:
            ii(0x1009_a7c0, 5); jmpd(0x1009_a5db, -0x1ea); goto l_0x1009_a5db; /* jmp 0x1009a5db */
        l_0x1009_a7c5:
            ii(0x1009_a7c5, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_a7c9, 2); if(jnzd(0x1009_a7de, 0x13)) goto l_0x1009_a7de; /* jnz 0x1009a7de */
            ii(0x1009_a7cb, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_a7cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a7d1, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a7d4, 5); calld(0x1007_5f6c, -0x2_486d);          /* call 0x10075f6c */
            ii(0x1009_a7d9, 5); jmpd(0x1009_a86c, 0x8e); goto l_0x1009_a86c; /* jmp 0x1009a86c */
        l_0x1009_a7de:
            ii(0x1009_a7de, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1009_a7e3, 5); calld(Definitions.sys_new, 0xc_b618);   /* call 0x10165e00 */
            ii(0x1009_a7e8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_a7eb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_a7ee, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_a7f1, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1009_a7f5, 2); if(jzd(0x1009_a819, 0x22)) goto l_0x1009_a819; /* jz 0x1009a819 */
            ii(0x1009_a7f7, 5); mov(eax, 0x1009_a542);                  /* mov eax, 0x1009a542 */
            ii(0x1009_a7fc, 1); pushd(eax);                             /* push eax */
            ii(0x1009_a7fd, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1009_a800, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1009_a803, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a806, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_a809, 5); calld(0x100b_43b0, 0x1_9ba2);           /* call 0x100b43b0 */
            ii(0x1009_a80e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_a811, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_a814, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_a817, 2); jmpd(0x1009_a81f, 0x6); goto l_0x1009_a81f; /* jmp 0x1009a81f */
        l_0x1009_a819:
            ii(0x1009_a819, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_a81c, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1009_a81f:
            ii(0x1009_a81f, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x1009_a822, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_a825, 5); calld(0x1008_b060, -0xf7ca);            /* call 0x1008b060 */
            ii(0x1009_a82a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_a82d, 5); calld(0x1008_af84, -0xf8ae);            /* call 0x1008af84 */
            ii(0x1009_a832, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a834, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_a839, 5); calld(0x100a_4d50, 0xa512);             /* call 0x100a4d50 */
            ii(0x1009_a83e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_a842, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a844, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_a847, 5); calld(0x1008_8b7c, -0x1_1cd0);          /* call 0x10088b7c */
            ii(0x1009_a84c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a84e, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_a851, 5); calld(0x1007_5f6c, -0x2_48ea);          /* call 0x10075f6c */
            ii(0x1009_a856, 2); jmpd(0x1009_a86c, 0x14); goto l_0x1009_a86c; /* jmp 0x1009a86c */
        //  ii(0x1009_a858, 20); Недостижимый код.
        l_0x1009_a86c:
            ii(0x1009_a86c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_a86f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a871, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a872, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a873, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a874, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a875, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a876, 1); retd(); return;                         /* ret */
        }
    }
}
