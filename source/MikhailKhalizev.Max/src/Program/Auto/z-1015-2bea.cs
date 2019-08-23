using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2bea-22b11b5a")]
        public void Method_1015_2bea()
        {
            ii(0x1015_2bea, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_2bef, 5); calld(Definitions.sys_check_available_stack_size, 0x1_315e); /* call 0x10165d52 */
            ii(0x1015_2bf4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2bf5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2bf6, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2bf7, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2bf8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2bf9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2bfb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_2c01, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_2c04, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_2c07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c0a, 6); mov(edx, memd_a32[ds, eax + 0xc5]);     /* mov edx, [eax+0xc5] */
            ii(0x1015_2c10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c13, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x1015_2c16, 2); if(jged(0x1015_2c28, 0x10)) goto l_0x1015_2c28; /* jge 0x10152c28 */
            ii(0x1015_2c18, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c1b, 6); mov(edx, memd_a32[ds, eax + 0xcd]);     /* mov edx, [eax+0xcd] */
            ii(0x1015_2c21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c24, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1015_2c26, 2); if(jged(0x1015_2c2a, 0x2)) goto l_0x1015_2c2a; /* jge 0x10152c2a */
        l_0x1015_2c28:
            ii(0x1015_2c28, 2); jmpd(0x1015_2c3b, 0x11); goto l_0x1015_2c3b; /* jmp 0x10152c3b */
        l_0x1015_2c2a:
            ii(0x1015_2c2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c2d, 6); mov(edx, memd_a32[ds, eax + 0xc9]);     /* mov edx, [eax+0xc9] */
            ii(0x1015_2c33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c36, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x1015_2c39, 2); if(jld(0x1015_2c3d, 0x2)) goto l_0x1015_2c3d; /* jl 0x10152c3d */
        l_0x1015_2c3b:
            ii(0x1015_2c3b, 2); jmpd(0x1015_2c4e, 0x11); goto l_0x1015_2c4e; /* jmp 0x10152c4e */
        l_0x1015_2c3d:
            ii(0x1015_2c3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c40, 6); mov(edx, memd_a32[ds, eax + 0xd1]);     /* mov edx, [eax+0xd1] */
            ii(0x1015_2c46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c49, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x1015_2c4c, 2); if(jged(0x1015_2c50, 0x2)) goto l_0x1015_2c50; /* jge 0x10152c50 */
        l_0x1015_2c4e:
            ii(0x1015_2c4e, 2); jmpd(0x1015_2c56, 0x6); goto l_0x1015_2c56; /* jmp 0x10152c56 */
        l_0x1015_2c50:
            ii(0x1015_2c50, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_2c54, 2); jmpd(0x1015_2caf, 0x59); goto l_0x1015_2caf; /* jmp 0x10152caf */
        l_0x1015_2c56:
            ii(0x1015_2c56, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c59, 6); mov(edx, memd_a32[ds, eax + 0xb5]);     /* mov edx, [eax+0xb5] */
            ii(0x1015_2c5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c62, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x1015_2c65, 2); if(jged(0x1015_2c77, 0x10)) goto l_0x1015_2c77; /* jge 0x10152c77 */
            ii(0x1015_2c67, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c6a, 6); mov(edx, memd_a32[ds, eax + 0xbd]);     /* mov edx, [eax+0xbd] */
            ii(0x1015_2c70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c73, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1015_2c75, 2); if(jged(0x1015_2c79, 0x2)) goto l_0x1015_2c79; /* jge 0x10152c79 */
        l_0x1015_2c77:
            ii(0x1015_2c77, 2); jmpd(0x1015_2c8a, 0x11); goto l_0x1015_2c8a; /* jmp 0x10152c8a */
        l_0x1015_2c79:
            ii(0x1015_2c79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c7c, 6); mov(edx, memd_a32[ds, eax + 0xb9]);     /* mov edx, [eax+0xb9] */
            ii(0x1015_2c82, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c85, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x1015_2c88, 2); if(jld(0x1015_2c8c, 0x2)) goto l_0x1015_2c8c; /* jl 0x10152c8c */
        l_0x1015_2c8a:
            ii(0x1015_2c8a, 2); jmpd(0x1015_2c9d, 0x11); goto l_0x1015_2c9d; /* jmp 0x10152c9d */
        l_0x1015_2c8c:
            ii(0x1015_2c8c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2c8f, 6); mov(edx, memd_a32[ds, eax + 0xc1]);     /* mov edx, [eax+0xc1] */
            ii(0x1015_2c95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2c98, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x1015_2c9b, 2); if(jged(0x1015_2c9f, 0x2)) goto l_0x1015_2c9f; /* jge 0x10152c9f */
        l_0x1015_2c9d:
            ii(0x1015_2c9d, 2); jmpd(0x1015_2ca5, 0x6); goto l_0x1015_2ca5; /* jmp 0x10152ca5 */
        l_0x1015_2c9f:
            ii(0x1015_2c9f, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_2ca3, 2); jmpd(0x1015_2ca9, 0x4); goto l_0x1015_2ca9; /* jmp 0x10152ca9 */
        l_0x1015_2ca5:
            ii(0x1015_2ca5, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_2ca9:
            ii(0x1015_2ca9, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1015_2cac, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1015_2caf:
            ii(0x1015_2caf, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_2cb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2cb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2cb5, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2cb6, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2cb7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2cb8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2cb9, 1); retd();                                 /* ret */
        }
    }
}
