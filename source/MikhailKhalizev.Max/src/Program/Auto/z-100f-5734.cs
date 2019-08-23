using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_5734-252538ab")]
        public void Method_100f_5734()
        {
            ii(0x100f_5734, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_5739, 5); call(Definitions.sys_check_available_stack_size, 0x7_0614); /* call 0x10165d52 */
            ii(0x100f_573e, 1); push(ebx);                              /* push ebx */
            ii(0x100f_573f, 1); push(ecx);                              /* push ecx */
            ii(0x100f_5740, 1); push(edx);                              /* push edx */
            ii(0x100f_5741, 1); push(esi);                              /* push esi */
            ii(0x100f_5742, 1); push(edi);                              /* push edi */
            ii(0x100f_5743, 1); push(ebp);                              /* push ebp */
            ii(0x100f_5744, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_5746, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_574c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_5751, 5); call(0x1007_6338, -0x7_f41e);           /* call 0x10076338 */
            ii(0x100f_5756, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_5759, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_575b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_575d, 5); call(0x1007_64b8, -0x7_f2aa);           /* call 0x100764b8 */
            ii(0x100f_5762, 2); jmp(0x100f_576c, 0x8); goto l_0x100f_576c; /* jmp 0x100f576c */
        l_0x100f_5764:
            ii(0x100f_5764, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5767, 5); call(0x1007_6bf8, -0x7_eb74);           /* call 0x10076bf8 */
        l_0x100f_576c:
            ii(0x100f_576c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_576e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5771, 5); call(0x1013_ad71, 0x4_55fb);            /* call 0x1013ad71 */
            ii(0x100f_5776, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5778, 2); if(jz(0x100f_5799, 0x1f)) goto l_0x100f_5799; /* jz 0x100f5799 */
            ii(0x100f_577a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_577d, 5); call(0x1007_63a0, -0x7_f3e2);           /* call 0x100763a0 */
            ii(0x100f_5782, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_5786, 2); if(jnz(0x100f_5797, 0xf)) goto l_0x100f_5797; /* jnz 0x100f5797 */
            ii(0x100f_5788, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_578a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_578d, 5); call(0x1007_5f6c, -0x7_f826);           /* call 0x10075f6c */
            ii(0x100f_5792, 5); jmp(0x100f_59a3, 0x20c); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_5797:
            ii(0x100f_5797, 2); jmp(0x100f_5764, -0x35); goto l_0x100f_5764; /* jmp 0x100f5764 */
        l_0x100f_5799:
            ii(0x100f_5799, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_579e, 5); call(0x1007_6338, -0x7_f46b);           /* call 0x10076338 */
            ii(0x100f_57a3, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_57a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_57a8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_57aa, 5); call(0x1007_643c, -0x7_f373);           /* call 0x1007643c */
            ii(0x100f_57af, 2); jmp(0x100f_57b9, 0x8); goto l_0x100f_57b9; /* jmp 0x100f57b9 */
        l_0x100f_57b1:
            ii(0x100f_57b1, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_57b4, 5); call(0x1007_6bf8, -0x7_ebc1);           /* call 0x10076bf8 */
        l_0x100f_57b9:
            ii(0x100f_57b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_57bb, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_57be, 5); call(0x1013_ad71, 0x4_55ae);            /* call 0x1013ad71 */
            ii(0x100f_57c3, 2); test(al, al);                           /* test al, al */
            ii(0x100f_57c5, 2); if(jz(0x100f_57e6, 0x1f)) goto l_0x100f_57e6; /* jz 0x100f57e6 */
            ii(0x100f_57c7, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_57ca, 5); call(0x1007_63a0, -0x7_f42f);           /* call 0x100763a0 */
            ii(0x100f_57cf, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_57d3, 2); if(jnz(0x100f_57e4, 0xf)) goto l_0x100f_57e4; /* jnz 0x100f57e4 */
            ii(0x100f_57d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_57d7, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_57da, 5); call(0x1007_5f6c, -0x7_f873);           /* call 0x10075f6c */
            ii(0x100f_57df, 5); jmp(0x100f_59a3, 0x1bf); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_57e4:
            ii(0x100f_57e4, 2); jmp(0x100f_57b1, -0x35); goto l_0x100f_57b1; /* jmp 0x100f57b1 */
        l_0x100f_57e6:
            ii(0x100f_57e6, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_57eb, 5); call(0x1007_6338, -0x7_f4b8);           /* call 0x10076338 */
            ii(0x100f_57f0, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_57f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_57f5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_57f7, 5); call(0x1007_643c, -0x7_f3c0);           /* call 0x1007643c */
            ii(0x100f_57fc, 2); jmp(0x100f_5806, 0x8); goto l_0x100f_5806; /* jmp 0x100f5806 */
        l_0x100f_57fe:
            ii(0x100f_57fe, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5801, 5); call(0x1007_6bf8, -0x7_ec0e);           /* call 0x10076bf8 */
        l_0x100f_5806:
            ii(0x100f_5806, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5808, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_580b, 5); call(0x1013_ad71, 0x4_5561);            /* call 0x1013ad71 */
            ii(0x100f_5810, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5812, 2); if(jz(0x100f_5833, 0x1f)) goto l_0x100f_5833; /* jz 0x100f5833 */
            ii(0x100f_5814, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5817, 5); call(0x1007_63a0, -0x7_f47c);           /* call 0x100763a0 */
            ii(0x100f_581c, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_5820, 2); if(jnz(0x100f_5831, 0xf)) goto l_0x100f_5831; /* jnz 0x100f5831 */
            ii(0x100f_5822, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5824, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5827, 5); call(0x1007_5f6c, -0x7_f8c0);           /* call 0x10075f6c */
            ii(0x100f_582c, 5); jmp(0x100f_59a3, 0x172); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_5831:
            ii(0x100f_5831, 2); jmp(0x100f_57fe, -0x35); goto l_0x100f_57fe; /* jmp 0x100f57fe */
        l_0x100f_5833:
            ii(0x100f_5833, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_5838, 5); call(0x1007_6338, -0x7_f505);           /* call 0x10076338 */
            ii(0x100f_583d, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_5840, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5842, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5844, 5); call(0x1007_643c, -0x7_f40d);           /* call 0x1007643c */
            ii(0x100f_5849, 2); jmp(0x100f_5853, 0x8); goto l_0x100f_5853; /* jmp 0x100f5853 */
        l_0x100f_584b:
            ii(0x100f_584b, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_584e, 5); call(0x1007_6bf8, -0x7_ec5b);           /* call 0x10076bf8 */
        l_0x100f_5853:
            ii(0x100f_5853, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5855, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5858, 5); call(0x1013_ad71, 0x4_5514);            /* call 0x1013ad71 */
            ii(0x100f_585d, 2); test(al, al);                           /* test al, al */
            ii(0x100f_585f, 2); if(jz(0x100f_58a9, 0x48)) goto l_0x100f_58a9; /* jz 0x100f58a9 */
            ii(0x100f_5861, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5864, 5); call(0x1007_63a0, -0x7_f4c9);           /* call 0x100763a0 */
            ii(0x100f_5869, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_586c, 6); cmp(al, memb[ds, 0x101c_39b1]);         /* cmp al, [0x101c39b1] */
            ii(0x100f_5872, 2); if(jnz(0x100f_58a7, 0x33)) goto l_0x100f_58a7; /* jnz 0x100f58a7 */
            ii(0x100f_5874, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5877, 5); call(0x1007_63a0, -0x7_f4dc);           /* call 0x100763a0 */
            ii(0x100f_587c, 5); call(0x1014_f12b, 0x5_98aa);            /* call 0x1014f12b */
            ii(0x100f_5881, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x100f_5886, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x100f_588b, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_588e, 5); call(0x1007_63d4, -0x7_f4bf);           /* call 0x100763d4 */
            ii(0x100f_5893, 5); call(0x1016_3053, 0x6_d7bb);            /* call 0x10163053 */
            ii(0x100f_5898, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_589a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_589d, 5); call(0x1007_5f6c, -0x7_f936);           /* call 0x10075f6c */
            ii(0x100f_58a2, 5); jmp(0x100f_59a3, 0xfc); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_58a7:
            ii(0x100f_58a7, 2); jmp(0x100f_584b, -0x5e); goto l_0x100f_584b; /* jmp 0x100f584b */
        l_0x100f_58a9:
            ii(0x100f_58a9, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_58ae, 5); call(0x1007_6338, -0x7_f57b);           /* call 0x10076338 */
            ii(0x100f_58b3, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_58b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_58b8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_58ba, 5); call(0x1007_643c, -0x7_f483);           /* call 0x1007643c */
            ii(0x100f_58bf, 2); jmp(0x100f_58c9, 0x8); goto l_0x100f_58c9; /* jmp 0x100f58c9 */
        l_0x100f_58c1:
            ii(0x100f_58c1, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_58c4, 5); call(0x1007_6bf8, -0x7_ecd1);           /* call 0x10076bf8 */
        l_0x100f_58c9:
            ii(0x100f_58c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_58cb, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_58ce, 5); call(0x1013_ad71, 0x4_549e);            /* call 0x1013ad71 */
            ii(0x100f_58d3, 2); test(al, al);                           /* test al, al */
            ii(0x100f_58d5, 2); if(jz(0x100f_591f, 0x48)) goto l_0x100f_591f; /* jz 0x100f591f */
            ii(0x100f_58d7, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_58da, 5); call(0x1007_63a0, -0x7_f53f);           /* call 0x100763a0 */
            ii(0x100f_58df, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_58e2, 6); cmp(al, memb[ds, 0x101c_39b1]);         /* cmp al, [0x101c39b1] */
            ii(0x100f_58e8, 2); if(jnz(0x100f_591d, 0x33)) goto l_0x100f_591d; /* jnz 0x100f591d */
            ii(0x100f_58ea, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_58ed, 5); call(0x1007_63a0, -0x7_f552);           /* call 0x100763a0 */
            ii(0x100f_58f2, 5); call(0x1014_f12b, 0x5_9834);            /* call 0x1014f12b */
            ii(0x100f_58f7, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x100f_58fc, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x100f_5901, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5904, 5); call(0x1007_63d4, -0x7_f535);           /* call 0x100763d4 */
            ii(0x100f_5909, 5); call(0x1016_3053, 0x6_d745);            /* call 0x10163053 */
            ii(0x100f_590e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5910, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5913, 5); call(0x1007_5f6c, -0x7_f9ac);           /* call 0x10075f6c */
            ii(0x100f_5918, 5); jmp(0x100f_59a3, 0x86); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_591d:
            ii(0x100f_591d, 2); jmp(0x100f_58c1, -0x5e); goto l_0x100f_58c1; /* jmp 0x100f58c1 */
        l_0x100f_591f:
            ii(0x100f_591f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_5924, 5); call(0x1007_6338, -0x7_f5f1);           /* call 0x10076338 */
            ii(0x100f_5929, 3); lea(ebx, ebp - 0x4);                    /* lea ebx, [ebp-0x4] */
            ii(0x100f_592c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_592e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5930, 5); call(0x1007_643c, -0x7_f4f9);           /* call 0x1007643c */
            ii(0x100f_5935, 2); jmp(0x100f_593f, 0x8); goto l_0x100f_593f; /* jmp 0x100f593f */
        l_0x100f_5937:
            ii(0x100f_5937, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_593a, 5); call(0x1007_6bf8, -0x7_ed47);           /* call 0x10076bf8 */
        l_0x100f_593f:
            ii(0x100f_593f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5941, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5944, 5); call(0x1013_ad71, 0x4_5428);            /* call 0x1013ad71 */
            ii(0x100f_5949, 2); test(al, al);                           /* test al, al */
            ii(0x100f_594b, 2); if(jz(0x100f_5992, 0x45)) goto l_0x100f_5992; /* jz 0x100f5992 */
            ii(0x100f_594d, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5950, 5); call(0x1007_63a0, -0x7_f5b5);           /* call 0x100763a0 */
            ii(0x100f_5955, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_5958, 6); cmp(al, memb[ds, 0x101c_39b1]);         /* cmp al, [0x101c39b1] */
            ii(0x100f_595e, 2); if(jnz(0x100f_5990, 0x30)) goto l_0x100f_5990; /* jnz 0x100f5990 */
            ii(0x100f_5960, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5963, 5); call(0x1007_63a0, -0x7_f5c8);           /* call 0x100763a0 */
            ii(0x100f_5968, 5); call(0x1014_f12b, 0x5_97be);            /* call 0x1014f12b */
            ii(0x100f_596d, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x100f_5972, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x100f_5977, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_597a, 5); call(0x1007_63d4, -0x7_f5ab);           /* call 0x100763d4 */
            ii(0x100f_597f, 5); call(0x1016_3053, 0x6_d6cf);            /* call 0x10163053 */
            ii(0x100f_5984, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5986, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_5989, 5); call(0x1007_5f6c, -0x7_fa22);           /* call 0x10075f6c */
            ii(0x100f_598e, 2); jmp(0x100f_59a3, 0x13); goto l_0x100f_59a3; /* jmp 0x100f59a3 */
        l_0x100f_5990:
            ii(0x100f_5990, 2); jmp(0x100f_5937, -0x5b); goto l_0x100f_5937; /* jmp 0x100f5937 */
        l_0x100f_5992:
            ii(0x100f_5992, 7); mov(memb[ds, 0x101c_39b0], 0);          /* mov byte [0x101c39b0], 0x0 */
            ii(0x100f_5999, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_599b, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100f_599e, 5); call(0x1007_5f6c, -0x7_fa37);           /* call 0x10075f6c */
        l_0x100f_59a3:
            ii(0x100f_59a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_59a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_59a6, 1); pop(edi);                               /* pop edi */
            ii(0x100f_59a7, 1); pop(esi);                               /* pop esi */
            ii(0x100f_59a8, 1); pop(edx);                               /* pop edx */
            ii(0x100f_59a9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_59aa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_59ab, 1); ret();                                  /* ret */
        }
    }
}
