using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a147-6f09fbcf")]
        public void Method_100f_a147()
        {
            ii(0x100f_a147, 5); call(0x100f_40a6, -0x60a6);             /* call 0x100f40a6 */
            ii(0x100f_a14c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a14e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a153, 5); call(0x1013_ad71, 0x4_0c19);            /* call 0x1013ad71 */
            ii(0x100f_a158, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a15a, 2); if(jz(0x100f_a178, 0x1c)) goto l_0x100f_a178; /* jz 0x100fa178 */
            ii(0x100f_a15c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a161, 5); call(0x1007_6574, -0x8_3bf2);           /* call 0x10076574 */
            ii(0x100f_a166, 4); mov(memb[ds, eax + 86], 0);             /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a16a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a16f, 5); call(0x1007_6574, -0x8_3c00);           /* call 0x10076574 */
            ii(0x100f_a174, 4); mov(memb[ds, eax + 85], 0);             /* mov byte [eax+0x55], 0x0 */
        l_0x100f_a178:
            ii(0x100f_a178, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_a17c, 2); if(jz(0x100f_a18b, 0xd)) goto l_0x100f_a18b; /* jz 0x100fa18b */
            ii(0x100f_a17e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_a181, 5); call(0x100f_92fe, -0xe88);              /* call 0x100f92fe */
            ii(0x100f_a186, 5); jmp(0x100f_a217, 0x8c); goto l_0x100f_a217; /* jmp 0x100fa217 */
        l_0x100f_a18b:
            ii(0x100f_a18b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a18d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a192, 5); call(0x1013_ad71, 0x4_0bda);            /* call 0x1013ad71 */
            ii(0x100f_a197, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a199, 2); if(jz(0x100f_a1ac, 0x11)) goto l_0x100f_a1ac; /* jz 0x100fa1ac */
            ii(0x100f_a19b, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_a19e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a1a3, 5); call(0x1007_6e00, -0x8_33a8);           /* call 0x10076e00 */
            ii(0x100f_a1a8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1aa, 2); if(jnz(0x100f_a1b2, 6)) goto l_0x100f_a1b2; /* jnz 0x100fa1b2 */
        l_0x100f_a1ac:
            ii(0x100f_a1ac, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_a1b0, 2); if(jz(0x100f_a217, 0x65)) goto l_0x100f_a217; /* jz 0x100fa217 */
        l_0x100f_a1b2:
            ii(0x100f_a1b2, 7); cmp(memb[ds, 0x101c_388c], 0);          /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_a1b9, 2); if(jz(0x100f_a1e2, 0x27)) goto l_0x100f_a1e2; /* jz 0x100fa1e2 */
            ii(0x100f_a1bb, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_a1be, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a1c3, 5); call(0x1008_aab4, -0x6_f714);           /* call 0x1008aab4 */
            ii(0x100f_a1c8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1ca, 2); if(jz(0x100f_a1d3, 7)) goto l_0x100f_a1d3; /* jz 0x100fa1d3 */
            ii(0x100f_a1cc, 5); call(0x100f_f5c1, 0x53f0);              /* call 0x100ff5c1 */
            ii(0x100f_a1d1, 2); jmp(0x100f_a1e0, 0xd); goto l_0x100f_a1e0; /* jmp 0x100fa1e0 */
        l_0x100f_a1d3:
            ii(0x100f_a1d3, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_a1d6, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a1db, 5); call(0x1008_ab1c, -0x6_f6c4);           /* call 0x1008ab1c */
        l_0x100f_a1e0:
            ii(0x100f_a1e0, 2); jmp(0x100f_a217, 0x35); goto l_0x100f_a217; /* jmp 0x100fa217 */
        l_0x100f_a1e2:
            ii(0x100f_a1e2, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_a1e5, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a1ea, 5); call(0x1008_b4ec, -0x6_ed03);           /* call 0x1008b4ec */
            ii(0x100f_a1ef, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1f1, 2); if(jz(0x100f_a217, 0x24)) goto l_0x100f_a217; /* jz 0x100fa217 */
            ii(0x100f_a1f3, 6); mov(ecx, memd[ds, 0x101c_3908]);        /* mov ecx, [0x101c3908] */
            ii(0x100f_a1f9, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a1fc, 6); mov(ebx, memd[ds, 0x101c_3906]);        /* mov ebx, [0x101c3906] */
            ii(0x100f_a202, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a205, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_a208, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a20d, 5); call(0x1007_65d0, -0x8_3c42);           /* call 0x100765d0 */
            ii(0x100f_a212, 5); call(0x100f_927b, -0xf9c);              /* call 0x100f927b */
        l_0x100f_a217:
            ii(0x100f_a217, 5); if(jmp_func(0x100f_a75d, 0x541)) return; /* jmp 0x100fa75d */
        }
    }
}
