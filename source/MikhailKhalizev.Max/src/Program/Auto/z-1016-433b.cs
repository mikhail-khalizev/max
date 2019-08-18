using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dda4157c-0cc1-4be3-8afb-0db581f49f5a")]
        public void Method_1016_433b()
        {
            ii(0x1016_433b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_4340, 5); calld(Definitions.sys_check_available_stack_size, 0x1a0d); /* call 0x10165d52 */
            ii(0x1016_4345, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4346, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4347, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4348, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4349, 1); pushd(edi);                             /* push edi */
            ii(0x1016_434a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_434b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_434d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4353, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4356, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4359, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_435c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_435f, 3); cmp(eax, 0x47);                         /* cmp eax, 0x47 */
            ii(0x1016_4362, 2); if(jnzd(0x1016_436a, 0x6)) goto l_0x1016_436a; /* jnz 0x1016436a */
            ii(0x1016_4364, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1016_4368, 2); jmpd(0x1016_43af, 0x45); goto l_0x1016_43af; /* jmp 0x101643af */
        l_0x1016_436a:
            ii(0x1016_436a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_436d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_4370, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_4373, 3); cmp(eax, 0x41);                         /* cmp eax, 0x41 */
            ii(0x1016_4376, 2); if(jnzd(0x1016_43ab, 0x33)) goto l_0x1016_43ab; /* jnz 0x101643ab */
            ii(0x1016_4378, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_437b, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1016_437e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_4381, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4384, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1016_4387, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_438a, 5); calld(0x1007_3d48, -0xf_0647);          /* call 0x10073d48 */
            ii(0x1016_438f, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_4394, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1016_4397, 2); if(jnzd(0x1016_439f, 0x6)) goto l_0x1016_439f; /* jnz 0x1016439f */
            ii(0x1016_4399, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1016_439d, 2); jmpd(0x1016_43a3, 0x4); goto l_0x1016_43a3; /* jmp 0x101643a3 */
        l_0x1016_439f:
            ii(0x1016_439f, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1016_43a3:
            ii(0x1016_43a3, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1016_43a6, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1016_43a9, 2); jmpd(0x1016_43af, 0x4); goto l_0x1016_43af; /* jmp 0x101643af */
        l_0x1016_43ab:
            ii(0x1016_43ab, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1016_43af:
            ii(0x1016_43af, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1016_43b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_43b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_43b5, 1); popd(edi);                              /* pop edi */
            ii(0x1016_43b6, 1); popd(esi);                              /* pop esi */
            ii(0x1016_43b7, 1); popd(edx);                              /* pop edx */
            ii(0x1016_43b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_43b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_43ba, 1); retd(); return;                         /* ret */
        }
    }
}
