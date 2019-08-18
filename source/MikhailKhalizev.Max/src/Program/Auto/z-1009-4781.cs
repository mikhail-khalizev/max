using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("38cb8b5b-8400-41bb-a647-e62a8b231e10")]
        public void Method_1009_4781()
        {
            ii(0x1009_4781, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4783, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_4788, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_478b, 5); calld(0x1009_3e27, -0x969);             /* call 0x10093e27 */
            ii(0x1009_4790, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4792, 2); if(jzd(0x1009_47aa, 0x16)) goto l_0x1009_47aa; /* jz 0x100947aa */
            ii(0x1009_4794, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_4799, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1009_479e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_47a1, 5); calld(0x1009_3e27, -0x97f);             /* call 0x10093e27 */
            ii(0x1009_47a6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47a8, 2); if(jzd(0x1009_47ac, 0x2)) goto l_0x1009_47ac; /* jz 0x100947ac */
        l_0x1009_47aa:
            ii(0x1009_47aa, 2); jmpd(0x1009_47c5, 0x19); goto l_0x1009_47c5; /* jmp 0x100947c5 */
        l_0x1009_47ac:
            ii(0x1009_47ac, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_47b1, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_47b4, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1009_47b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_47bc, 5); calld(0x1009_6e02, 0x2641);             /* call 0x10096e02 */
            ii(0x1009_47c1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47c3, 2); if(jnzd(0x1009_47c7, 0x2)) goto l_0x1009_47c7; /* jnz 0x100947c7 */
        l_0x1009_47c5:
            ii(0x1009_47c5, 2); jmpd(0x1009_47d0, 0x9); goto l_0x1009_47d0; /* jmp 0x100947d0 */
        l_0x1009_47c7:
            ii(0x1009_47c7, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_47cb, 5); if(jmpd_func(0x1009_48ff, 0x12f)) return; /* jmp 0x100948ff */
        l_0x1009_47d0:
            ii(0x1009_47d0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_47d2, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_47d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_47da, 5); calld(0x1009_3e27, -0x9b8);             /* call 0x10093e27 */
            ii(0x1009_47df, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47e1, 2); if(jzd(0x1009_47f9, 0x16)) goto l_0x1009_47f9; /* jz 0x100947f9 */
            ii(0x1009_47e3, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_47e8, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1009_47ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_47f0, 5); calld(0x1009_3e27, -0x9ce);             /* call 0x10093e27 */
            ii(0x1009_47f5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47f7, 2); if(jzd(0x1009_47fb, 0x2)) goto l_0x1009_47fb; /* jz 0x100947fb */
        l_0x1009_47f9:
            ii(0x1009_47f9, 2); jmpd(0x1009_4814, 0x19); goto l_0x1009_4814; /* jmp 0x10094814 */
        l_0x1009_47fb:
            ii(0x1009_47fb, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_4800, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_4803, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1009_4808, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_480b, 5); calld(0x1009_6e02, 0x25f2);             /* call 0x10096e02 */
            ii(0x1009_4810, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4812, 2); if(jnzd(0x1009_4816, 0x2)) goto l_0x1009_4816; /* jnz 0x10094816 */
        l_0x1009_4814:
            ii(0x1009_4814, 2); jmpd(0x1009_481f, 0x9); goto l_0x1009_481f; /* jmp 0x1009481f */
        l_0x1009_4816:
            ii(0x1009_4816, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_481a, 5); if(jmpd_func(0x1009_48ff, 0xe0)) return; /* jmp 0x100948ff */
        l_0x1009_481f:
            ii(0x1009_481f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4821, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_4826, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4829, 5); calld(0x1009_3e27, -0xa07);             /* call 0x10093e27 */
            ii(0x1009_482e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4830, 2); if(jzd(0x1009_4848, 0x16)) goto l_0x1009_4848; /* jz 0x10094848 */
            ii(0x1009_4832, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_4837, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1009_483c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_483f, 5); calld(0x1009_3e27, -0xa1d);             /* call 0x10093e27 */
            ii(0x1009_4844, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4846, 2); if(jzd(0x1009_484a, 0x2)) goto l_0x1009_484a; /* jz 0x1009484a */
        l_0x1009_4848:
            ii(0x1009_4848, 2); jmpd(0x1009_4863, 0x19); goto l_0x1009_4863; /* jmp 0x10094863 */
        l_0x1009_484a:
            ii(0x1009_484a, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_484f, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_4852, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1009_4857, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_485a, 5); calld(0x1009_6e02, 0x25a3);             /* call 0x10096e02 */
            ii(0x1009_485f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4861, 2); if(jnzd(0x1009_4865, 0x2)) goto l_0x1009_4865; /* jnz 0x10094865 */
        l_0x1009_4863:
            ii(0x1009_4863, 2); jmpd(0x1009_486e, 0x9); goto l_0x1009_486e; /* jmp 0x1009486e */
        l_0x1009_4865:
            ii(0x1009_4865, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4869, 5); if(jmpd_func(0x1009_48ff, 0x91)) return; /* jmp 0x100948ff */
        l_0x1009_486e:
            ii(0x1009_486e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4870, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_4875, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4878, 5); calld(0x1009_3e27, -0xa56);             /* call 0x10093e27 */
            ii(0x1009_487d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_487f, 2); if(jzd(0x1009_4897, 0x16)) goto l_0x1009_4897; /* jz 0x10094897 */
            ii(0x1009_4881, 5); mov(ebx, 0x1d00);                       /* mov ebx, 0x1d00 */
            ii(0x1009_4886, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1009_488b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_488e, 5); calld(0x1009_3e27, -0xa6c);             /* call 0x10093e27 */
            ii(0x1009_4893, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4895, 2); if(jzd(0x1009_4899, 0x2)) goto l_0x1009_4899; /* jz 0x10094899 */
        l_0x1009_4897:
            ii(0x1009_4897, 2); jmpd(0x1009_48b2, 0x19); goto l_0x1009_48b2; /* jmp 0x100948b2 */
        l_0x1009_4899:
            ii(0x1009_4899, 5); mov(ecx, 0x1d00);                       /* mov ecx, 0x1d00 */
            ii(0x1009_489e, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_48a1, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1009_48a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_48a9, 5); calld(0x1009_6e02, 0x2554);             /* call 0x10096e02 */
            ii(0x1009_48ae, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48b0, 2); if(jnzd(0x1009_48b4, 0x2)) goto l_0x1009_48b4; /* jnz 0x100948b4 */
        l_0x1009_48b2:
            ii(0x1009_48b2, 2); jmpd(0x1009_48ba, 0x6); goto l_0x1009_48ba; /* jmp 0x100948ba */
        l_0x1009_48b4:
            ii(0x1009_48b4, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_48b8, 2); if(jmpd_func(0x1009_48ff, 0x45)) return; /* jmp 0x100948ff */
        l_0x1009_48ba:
            ii(0x1009_48ba, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_48be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_48c0, 2); if(jled(0x1009_48d8, 0x16)) goto l_0x1009_48d8; /* jle 0x100948d8 */
            ii(0x1009_48c2, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_48c7, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_48cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_48cf, 5); calld(0x1009_3e27, -0xaad);             /* call 0x10093e27 */
            ii(0x1009_48d4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48d6, 2); if(jzd(0x1009_48da, 0x2)) goto l_0x1009_48da; /* jz 0x100948da */
        l_0x1009_48d8:
            ii(0x1009_48d8, 2); jmpd(0x1009_48f3, 0x19); goto l_0x1009_48f3; /* jmp 0x100948f3 */
        l_0x1009_48da:
            ii(0x1009_48da, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_48df, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_48e2, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_48e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_48ea, 5); calld(0x1009_6e02, 0x2513);             /* call 0x10096e02 */
            ii(0x1009_48ef, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48f1, 2); if(jnzd(0x1009_48f5, 0x2)) goto l_0x1009_48f5; /* jnz 0x100948f5 */
        l_0x1009_48f3:
            ii(0x1009_48f3, 2); jmpd(0x1009_48fb, 0x6); goto l_0x1009_48fb; /* jmp 0x100948fb */
        l_0x1009_48f5:
            ii(0x1009_48f5, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_48f9, 2); if(jmpd_func(0x1009_48ff, 0x4)) return; /* jmp 0x100948ff */
        l_0x1009_48fb:
            ii(0x1009_48fb, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        }
    }
}
