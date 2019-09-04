using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a6d6-d11e4309")]
        public void Method_100b_a6d6()
        {
            ii(0x100b_a6d6, 5); push(0x38);                             /* push 0x38 */
            ii(0x100b_a6db, 5); call(Definitions.sys_check_available_stack_size, 0xa_b672); /* call 0x10165d52 */
            ii(0x100b_a6e0, 1); push(ebx);                              /* push ebx */
            ii(0x100b_a6e1, 1); push(ecx);                              /* push ecx */
            ii(0x100b_a6e2, 1); push(edx);                              /* push edx */
            ii(0x100b_a6e3, 1); push(esi);                              /* push esi */
            ii(0x100b_a6e4, 1); push(edi);                              /* push edi */
            ii(0x100b_a6e5, 1); push(ebp);                              /* push ebp */
            ii(0x100b_a6e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a6e8, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_a6ee, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_a6f1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a6f4, 3); mov(al, memb[ds, eax + 2]);             /* mov al, [eax+0x2] */
            ii(0x100b_a6f7, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100b_a6fa, 5); jmp(0x100b_a99c, 0x29d); goto l_0x100b_a99c; /* jmp 0x100ba99c */
        l_0x100b_a6ff:
            ii(0x100b_a6ff, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100b_a704, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100b_a709, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a70c, 5); call(0x100b_a2c3, -0x44e);              /* call 0x100ba2c3 */
            ii(0x100b_a711, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100b_a716, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x100b_a71b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a71e, 5); call(0x100b_a2c3, -0x460);              /* call 0x100ba2c3 */
            ii(0x100b_a723, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100b_a728, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x100b_a72d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a730, 5); call(0x100b_a2c3, -0x472);              /* call 0x100ba2c3 */
            ii(0x100b_a735, 5); jmp(0x100b_a9b9, 0x27f); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a73a:
            ii(0x100b_a73a, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a73f, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100b_a744, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a747, 5); call(0x100b_a2c3, -0x489);              /* call 0x100ba2c3 */
            ii(0x100b_a74c, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a751, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100b_a756, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a759, 5); call(0x100b_a2c3, -0x49b);              /* call 0x100ba2c3 */
            ii(0x100b_a75e, 5); jmp(0x100b_a9b9, 0x256); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a763:
            ii(0x100b_a763, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a768, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100b_a76d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a770, 5); call(0x100b_a2c3, -0x4b2);              /* call 0x100ba2c3 */
            ii(0x100b_a775, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a77a, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100b_a77f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a782, 5); call(0x100b_a2c3, -0x4c4);              /* call 0x100ba2c3 */
            ii(0x100b_a787, 5); jmp(0x100b_a9b9, 0x22d); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a78c:
            ii(0x100b_a78c, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a791, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100b_a796, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a799, 5); call(0x100b_a2c3, -0x4db);              /* call 0x100ba2c3 */
            ii(0x100b_a79e, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a7a3, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100b_a7a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a7ab, 5); call(0x100b_a2c3, -0x4ed);              /* call 0x100ba2c3 */
            ii(0x100b_a7b0, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a7b5, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100b_a7ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a7bd, 5); call(0x100b_a2c3, -0x4ff);              /* call 0x100ba2c3 */
            ii(0x100b_a7c2, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a7c7, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100b_a7cc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a7cf, 5); call(0x100b_a2c3, -0x511);              /* call 0x100ba2c3 */
            ii(0x100b_a7d4, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a7d9, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100b_a7de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a7e1, 5); call(0x100b_a2c3, -0x523);              /* call 0x100ba2c3 */
            ii(0x100b_a7e6, 5); jmp(0x100b_a9b9, 0x1ce); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a7eb:
            ii(0x100b_a7eb, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100b_a7f0, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100b_a7f5, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100b_a7f8, 5); call(0x100b_8462, -0x239b);             /* call 0x100b8462 */
            ii(0x100b_a7fd, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_a800, 6); add(ebx, 0x85);                         /* add ebx, 0x85 */
            ii(0x100b_a806, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a808, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_a80a, 5); call(0x1008_a41c, -0x3_03f3);           /* call 0x1008a41c */
            ii(0x100b_a80f, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a814, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100b_a819, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100b_a81c, 5); call(0x100b_8462, -0x23bf);             /* call 0x100b8462 */
            ii(0x100b_a821, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_a824, 6); add(ebx, 0x89);                         /* add ebx, 0x89 */
            ii(0x100b_a82a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a82c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_a82e, 5); call(0x1008_a41c, -0x3_0417);           /* call 0x1008a41c */
            ii(0x100b_a833, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100b_a838, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100b_a83d, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_a840, 5); call(0x100b_8462, -0x23e3);             /* call 0x100b8462 */
            ii(0x100b_a845, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a847, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a84a, 3); add(eax, 0x7d);                         /* add eax, 0x7d */
            ii(0x100b_a84d, 5); call(0x1008_a41c, -0x3_0436);           /* call 0x1008a41c */
            ii(0x100b_a852, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100b_a857, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100b_a85c, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_a85f, 5); call(0x100b_8462, -0x2402);             /* call 0x100b8462 */
            ii(0x100b_a864, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a866, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a869, 5); add(eax, 0x8d);                         /* add eax, 0x8d */
            ii(0x100b_a86e, 5); call(0x1008_a41c, -0x3_0457);           /* call 0x1008a41c */
            ii(0x100b_a873, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100b_a878, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100b_a87d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a880, 5); call(0x100b_a2c3, -0x5c2);              /* call 0x100ba2c3 */
            ii(0x100b_a885, 5); jmp(0x100b_a9b9, 0x12f); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a88a:
            ii(0x100b_a88a, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100b_a88f, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100b_a894, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a897, 5); call(0x100b_a2c3, -0x5d9);              /* call 0x100ba2c3 */
            ii(0x100b_a89c, 5); jmp(0x100b_a9b9, 0x118); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a8a1:
            ii(0x100b_a8a1, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100b_a8a6, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100b_a8ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a8ae, 5); call(0x100b_a2c3, -0x5f0);              /* call 0x100ba2c3 */
            ii(0x100b_a8b3, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a8b8, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100b_a8bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a8c0, 5); call(0x100b_a2c3, -0x602);              /* call 0x100ba2c3 */
            ii(0x100b_a8c5, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a8ca, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100b_a8cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a8d2, 5); call(0x100b_a2c3, -0x614);              /* call 0x100ba2c3 */
            ii(0x100b_a8d7, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a8dc, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100b_a8e1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a8e4, 5); call(0x100b_a2c3, -0x626);              /* call 0x100ba2c3 */
            ii(0x100b_a8e9, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a8ee, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100b_a8f3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a8f6, 5); call(0x100b_a2c3, -0x638);              /* call 0x100ba2c3 */
            ii(0x100b_a8fb, 5); jmp(0x100b_a9b9, 0xb9); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a900:
            ii(0x100b_a900, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a905, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100b_a90a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a90d, 5); call(0x100b_a2c3, -0x64f);              /* call 0x100ba2c3 */
            ii(0x100b_a912, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100b_a917, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100b_a91c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a91f, 5); call(0x100b_a2c3, -0x661);              /* call 0x100ba2c3 */
            ii(0x100b_a924, 5); jmp(0x100b_a9b9, 0x90); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a929:
            ii(0x100b_a929, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x100b_a92e, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100b_a933, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a936, 5); call(0x100b_a2c3, -0x678);              /* call 0x100ba2c3 */
            ii(0x100b_a93b, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x100b_a940, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100b_a945, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a948, 5); call(0x100b_a2c3, -0x68a);              /* call 0x100ba2c3 */
            ii(0x100b_a94d, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a952, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100b_a957, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a95a, 5); call(0x100b_a2c3, -0x69c);              /* call 0x100ba2c3 */
            ii(0x100b_a95f, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_a964, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100b_a969, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a96c, 5); call(0x100b_a2c3, -0x6ae);              /* call 0x100ba2c3 */
            ii(0x100b_a971, 2); jmp(0x100b_a9b9, 0x46); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        l_0x100b_a973:
            ii(0x100b_a973, 2); jmp(0x100b_a9b9, 0x44); goto l_0x100b_a9b9; /* jmp 0x100ba9b9 */
        //  ii(0x100b_a975, 3); lea(eax, memd[ds, eax]);                /* lea eax, [eax] */
        //  ii(0x100b_a978, 36); /* Служебная область с абсолютными адресами переходов. (0x100b_a6ff, 0x100b_a73a, 0x100b_a763, 0x100b_a78c, 0x100b_a7eb, 0x100b_a88a, 0x100b_a8a1, 0x100b_a900, 0x100b_a929). */
        l_0x100b_a99c:
            ii(0x100b_a99c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100b_a99f, 2); dec(al);                                /* dec al */
            ii(0x100b_a9a1, 3); mov(memb[ss, ebp - 28], al);            /* mov [ebp-0x1c], al */
            ii(0x100b_a9a4, 4); cmp(memb[ss, ebp - 28], 8);             /* cmp byte [ebp-0x1c], 0x8 */
            ii(0x100b_a9a8, 2); if(ja(0x100b_a973, -0x37)) goto l_0x100b_a973; /* ja 0x100ba973 */
            ii(0x100b_a9aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_a9ac, 3); mov(al, memb[ss, ebp - 28]);            /* mov al, [ebp-0x1c] */
            ii(0x100b_a9af, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_a9b2, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x100b_a978]))
            {
                case 0x100b_a6ff:
                    goto l_0x100b_a6ff;
                case 0x100b_a73a:
                    goto l_0x100b_a73a;
                case 0x100b_a763:
                    goto l_0x100b_a763;
                case 0x100b_a78c:
                    goto l_0x100b_a78c;
                case 0x100b_a7eb:
                    goto l_0x100b_a7eb;
                case 0x100b_a88a:
                    goto l_0x100b_a88a;
                case 0x100b_a8a1:
                    goto l_0x100b_a8a1;
                case 0x100b_a900:
                    goto l_0x100b_a900;
                case 0x100b_a929:
                    goto l_0x100b_a929;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100ba978] */
        l_0x100b_a9b9:
            ii(0x100b_a9b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a9bb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_a9bc, 1); pop(edi);                               /* pop edi */
            ii(0x100b_a9bd, 1); pop(esi);                               /* pop esi */
            ii(0x100b_a9be, 1); pop(edx);                               /* pop edx */
            ii(0x100b_a9bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_a9c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_a9c1, 1); ret();                                  /* ret */
        }
    }
}
