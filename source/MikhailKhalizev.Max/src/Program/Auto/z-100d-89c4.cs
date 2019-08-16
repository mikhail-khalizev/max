using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("696de467-3aeb-4fec-8793-95c1ab51449c")]
        public void Method_100d_89c4()
        {
            ii(0x100d_89c4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_89c9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d384); /* call 0x10165d52 */
            ii(0x100d_89ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_89cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_89d0, 1); pushd(edx);                             /* push edx */
            ii(0x100d_89d1, 1); pushd(esi);                             /* push esi */
            ii(0x100d_89d2, 1); pushd(edi);                             /* push edi */
            ii(0x100d_89d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_89d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_89d6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_89dc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_89df, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_89e4, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100d_89e9, 5); calld(0x1013_dc59, 0x6_526b);           /* call 0x1013dc59 */
            ii(0x100d_89ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_89f1, 4); cmp(memb_a32[ds, eax + 0xe], 0x9);      /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_89f5, 2); if(jzd(0x100d_8a09, 0x12)) goto l_0x100d_8a09; /* jz 0x100d8a09 */
            ii(0x100d_89f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_89fa, 5); calld(0x100d_86f5, -0x30a);             /* call 0x100d86f5 */
            ii(0x100d_89ff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8a01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a04, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_8a06, 3); sub(memw_a32[ds, eax], dx);             /* sub [eax], dx */
        l_0x100d_8a09:
            ii(0x100d_8a09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a0c, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100d_8a0f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_8a12, 4); mov(dx, memw_a32[ds, edx + 0x13]);      /* mov dx, [edx+0x13] */
            ii(0x100d_8a16, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x100d_8a19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a1c, 4); cmp(memd_a32[ds, eax + 0x1b], 0);       /* cmp dword [eax+0x1b], 0x0 */
            ii(0x100d_8a20, 2); if(jzd(0x100d_8a3e, 0x1c)) goto l_0x100d_8a3e; /* jz 0x100d8a3e */
            ii(0x100d_8a22, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a25, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100d_8a28, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100d_8a2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a2e, 5); calld(0x100d_8528, -0x50b);             /* call 0x100d8528 */
            ii(0x100d_8a33, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8a35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a38, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100d_8a3b, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
        l_0x100d_8a3e:
            ii(0x100d_8a3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a41, 4); cmp(memb_a32[ds, eax + 0xe], 0x9);      /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_8a45, 2); if(jnzd(0x100d_8a59, 0x12)) goto l_0x100d_8a59; /* jnz 0x100d8a59 */
            ii(0x100d_8a47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a4a, 5); calld(0x100d_86f5, -0x35a);             /* call 0x100d86f5 */
            ii(0x100d_8a4f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8a51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a54, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_8a56, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
        l_0x100d_8a59:
            ii(0x100d_8a59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8a5b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8a5c, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8a5d, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8a5e, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8a5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8a60, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8a61, 1); retd(); return;                         /* ret */
        }
    }
}