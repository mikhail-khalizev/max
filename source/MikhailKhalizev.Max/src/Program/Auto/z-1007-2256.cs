using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ee3706d4-c015-40ce-8f6f-ee8a3a0ac8bd")]
        public void Method_1007_2256()
        {
            ii(0x1007_2256, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_225b, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3af2); /* call 0x10165d52 */
            ii(0x1007_2260, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_2261, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2262, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2263, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2264, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2265, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2267, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_226d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_2270, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_2273, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2276, 5); calld(0x1007_20e6, -0x195);             /* call 0x100720e6 */
            ii(0x1007_227b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_227e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_2281, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_2284, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_2287, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1007_228d, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1007_2290, 2); jmpd(0x1007_22d2, 0x40); goto l_0x1007_22d2; /* jmp 0x100722d2 */
        l_0x1007_2292:
            ii(0x1007_2292, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_2295, 5); calld(0x1007_623c, 0x3fa2);             /* call 0x1007623c */
            ii(0x1007_229a, 4); mov(dx, memw_a32[ds, eax + 0x19]);      /* mov dx, [eax+0x19] */
            ii(0x1007_229e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_22a1, 4); add(memw_a32[ds, eax + 0x2], dx);       /* add [eax+0x2], dx */
            ii(0x1007_22a5, 2); jmpd(0x1007_22f4, 0x4d); goto l_0x1007_22f4; /* jmp 0x100722f4 */
        l_0x1007_22a7:
            ii(0x1007_22a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_22aa, 5); calld(0x1007_623c, 0x3f8d);             /* call 0x1007623c */
            ii(0x1007_22af, 4); mov(dx, memw_a32[ds, eax + 0x19]);      /* mov dx, [eax+0x19] */
            ii(0x1007_22b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_22b6, 4); add(memw_a32[ds, eax + 0x4], dx);       /* add [eax+0x4], dx */
            ii(0x1007_22ba, 2); jmpd(0x1007_22f4, 0x38); goto l_0x1007_22f4; /* jmp 0x100722f4 */
        l_0x1007_22bc:
            ii(0x1007_22bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_22bf, 5); calld(0x1007_623c, 0x3f78);             /* call 0x1007623c */
            ii(0x1007_22c4, 4); mov(dx, memw_a32[ds, eax + 0x19]);      /* mov dx, [eax+0x19] */
            ii(0x1007_22c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_22cb, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x1007_22ce, 2); jmpd(0x1007_22f4, 0x24); goto l_0x1007_22f4; /* jmp 0x100722f4 */
        l_0x1007_22d0:
            ii(0x1007_22d0, 2); jmpd(0x1007_22f4, 0x22); goto l_0x1007_22f4; /* jmp 0x100722f4 */
        l_0x1007_22d2:
            ii(0x1007_22d2, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_22d5, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1007_22d8, 4); cmp(memb_a32[ss, ebp - 0x14], 0x2);     /* cmp byte [ebp-0x14], 0x2 */
            ii(0x1007_22dc, 2); if(jbd(0x1007_22ec, 0xe)) goto l_0x1007_22ec; /* jb 0x100722ec */
            ii(0x1007_22de, 4); cmp(memb_a32[ss, ebp - 0x14], 0x2);     /* cmp byte [ebp-0x14], 0x2 */
            ii(0x1007_22e2, 2); if(jbed(0x1007_22a7, -0x3d)) goto l_0x1007_22a7; /* jbe 0x100722a7 */
            ii(0x1007_22e4, 4); cmp(memb_a32[ss, ebp - 0x14], 0x3);     /* cmp byte [ebp-0x14], 0x3 */
            ii(0x1007_22e8, 2); if(jzd(0x1007_22bc, -0x2e)) goto l_0x1007_22bc; /* jz 0x100722bc */
            ii(0x1007_22ea, 2); jmpd(0x1007_22d0, -0x1c); goto l_0x1007_22d0; /* jmp 0x100722d0 */
        l_0x1007_22ec:
            ii(0x1007_22ec, 4); cmp(memb_a32[ss, ebp - 0x14], 0x1);     /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1007_22f0, 2); if(jzd(0x1007_2292, -0x60)) goto l_0x1007_2292; /* jz 0x10072292 */
            ii(0x1007_22f2, 2); jmpd(0x1007_22d0, -0x24); goto l_0x1007_22d0; /* jmp 0x100722d0 */
        l_0x1007_22f4:
            ii(0x1007_22f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_22f7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_22fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_22fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_22ff, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_2300, 1); popd(edi);                              /* pop edi */
            ii(0x1007_2301, 1); popd(esi);                              /* pop esi */
            ii(0x1007_2302, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2303, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_2304, 1); retd(); return;                         /* ret */
        }
    }
}
