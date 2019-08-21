using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d9f4-b88c50af")]
        public void Method_1008_d9f4()
        {
            ii(0x1008_d9f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9f7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9fa, 5); calld(0x1007_6574, -0x1_748b);          /* call 0x10076574 */
            ii(0x1008_d9ff, 5); calld(0x1015_26ac, 0xc_4ca8);           /* call 0x101526ac */
            ii(0x1008_da04, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_da07, 6); if(jnzd(0x1008_dac2, 0xb5)) goto l_0x1008_dac2; /* jnz 0x1008dac2 */
            ii(0x1008_da0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da10, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da13, 5); calld(0x1007_6574, -0x1_74a4);          /* call 0x10076574 */
            ii(0x1008_da18, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_da1c, 2); if(jnzd(0x1008_da37, 0x19)) goto l_0x1008_da37; /* jnz 0x1008da37 */
            ii(0x1008_da1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da21, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_da25, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_da2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da2d, 5); calld(0x100a_28ff, 0x1_4ecd);           /* call 0x100a28ff */
            ii(0x1008_da32, 5); jmpd(0x1008_dac2, 0x8b); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_da37:
            ii(0x1008_da37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da3a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da3d, 5); calld(0x1007_6574, -0x1_74ce);          /* call 0x10076574 */
            ii(0x1008_da42, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1008_da46, 2); if(jnzd(0x1008_da5d, 0x15)) goto l_0x1008_da5d; /* jnz 0x1008da5d */
            ii(0x1008_da48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da4b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da4e, 5); calld(0x1007_6574, -0x1_74df);          /* call 0x10076574 */
            ii(0x1008_da53, 5); calld(0x1015_26ac, 0xc_4c54);           /* call 0x101526ac */
            ii(0x1008_da58, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_da5b, 2); if(jzd(0x1008_da5f, 0x2)) goto l_0x1008_da5f; /* jz 0x1008da5f */
        l_0x1008_da5d:
            ii(0x1008_da5d, 2); jmpd(0x1008_da69, 0xa); goto l_0x1008_da69; /* jmp 0x1008da69 */
        l_0x1008_da5f:
            ii(0x1008_da5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da62, 5); calld(0x1008_d461, -0x606);             /* call 0x1008d461 */
            ii(0x1008_da67, 2); jmpd(0x1008_dac2, 0x59); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_da69:
            ii(0x1008_da69, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da6c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da6f, 5); calld(0x1007_6574, -0x1_7500);          /* call 0x10076574 */
            ii(0x1008_da74, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1008_da78, 2); if(jnzd(0x1008_da8b, 0x11)) goto l_0x1008_da8b; /* jnz 0x1008da8b */
            ii(0x1008_da7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da7d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da80, 5); calld(0x1007_6574, -0x1_7511);          /* call 0x10076574 */
            ii(0x1008_da85, 4); cmp(memb_a32[ds, eax + 0x3e], 0xb);     /* cmp byte [eax+0x3e], 0xb */
            ii(0x1008_da89, 2); if(jzd(0x1008_da8d, 0x2)) goto l_0x1008_da8d; /* jz 0x1008da8d */
        l_0x1008_da8b:
            ii(0x1008_da8b, 2); jmpd(0x1008_dab8, 0x2b); goto l_0x1008_dab8; /* jmp 0x1008dab8 */
        l_0x1008_da8d:
            ii(0x1008_da8d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_da8f, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1008_da94, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_da97, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_da9a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_da9d, 5); calld(0x1007_5e64, -0x1_7c3e);          /* call 0x10075e64 */
            ii(0x1008_daa2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_daa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_daa7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_daaa, 5); calld(0x1008_abbc, -0x2ef3);            /* call 0x1008abbc */
            ii(0x1008_daaf, 5); calld(0x100a_90f9, 0x1_b645);           /* call 0x100a90f9 */
            ii(0x1008_dab4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dab6, 2); if(jnzd(0x1008_daba, 0x2)) goto l_0x1008_daba; /* jnz 0x1008daba */
        l_0x1008_dab8:
            ii(0x1008_dab8, 2); jmpd(0x1008_dac2, 0x8); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_daba:
            ii(0x1008_daba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dabd, 5); calld(0x1008_d5fb, -0x4c7);             /* call 0x1008d5fb */
        l_0x1008_dac2:
            ii(0x1008_dac2, 5); if(jmpd_func(0x1008_db55, 0x8e)) return; /* jmp 0x1008db55 */
        }
    }
}
