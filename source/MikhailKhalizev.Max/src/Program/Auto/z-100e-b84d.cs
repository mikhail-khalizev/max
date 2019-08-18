using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b84d-3d94167d")]
        public void Method_100e_b84d()
        {
            ii(0x100e_b84d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b852, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a4fb); /* call 0x10165d52 */
            ii(0x100e_b857, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b858, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b859, 1); pushd(edx);                             /* push edx */
            ii(0x100e_b85a, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b85b, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b85c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b85d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b85f, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_b865, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_b868, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b86b, 4); cmp(memb_a32[ds, eax + 0x32], 0);       /* cmp byte [eax+0x32], 0x0 */
            ii(0x100e_b86f, 2); if(jzd(0x100e_b87e, 0xd)) goto l_0x100e_b87e; /* jz 0x100eb87e */
            ii(0x100e_b871, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b874, 5); calld(0x100e_b58f, -0x2ea);             /* call 0x100eb58f */
            ii(0x100e_b879, 5); jmpd(0x100e_b921, 0xa3); goto l_0x100e_b921; /* jmp 0x100eb921 */
        l_0x100e_b87e:
            ii(0x100e_b87e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b881, 3); mov(edx, memd_a32[ds, eax + 0x2a]);     /* mov edx, [eax+0x2a] */
            ii(0x100e_b884, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_b887, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b88a, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b88d, 5); calld(Definitions.sys_strlen, 0x8_6635); /* call 0x10171ec7 */
            ii(0x100e_b892, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_b894, 6); if(jzd(0x100e_b921, 0x87)) goto l_0x100e_b921; /* jz 0x100eb921 */
            ii(0x100e_b89a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b89d, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_b8a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8a4, 5); calld(0x100e_b6bf, -0x1ea);             /* call 0x100eb6bf */
            ii(0x100e_b8a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8ac, 3); mov(ebx, memd_a32[ds, eax + 0x2a]);     /* mov ebx, [eax+0x2a] */
            ii(0x100e_b8af, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_b8b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8b5, 3); mov(edx, memd_a32[ds, eax + 0x23]);     /* mov edx, [eax+0x23] */
            ii(0x100e_b8b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8bb, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_b8be, 5); calld(Definitions.sys_strncpy, 0x8_661d); /* call 0x10171ee0 */
            ii(0x100e_b8c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8c6, 3); mov(edx, memd_a32[ds, eax + 0x2a]);     /* mov edx, [eax+0x2a] */
            ii(0x100e_b8c9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_b8cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8cf, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_b8d2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_b8d4, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x100e_b8d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8da, 3); mov(ebx, memd_a32[ds, eax + 0x2a]);     /* mov ebx, [eax+0x2a] */
            ii(0x100e_b8dd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_b8e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8e3, 3); mov(edx, memd_a32[ds, eax + 0x23]);     /* mov edx, [eax+0x23] */
            ii(0x100e_b8e6, 1); inc(ebx);                               /* inc ebx */
            ii(0x100e_b8e7, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100e_b8e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8ec, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_b8ef, 5); calld(Definitions.sys_strcat, 0x7_a63d); /* call 0x10165f31 */
            ii(0x100e_b8f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8f7, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x100e_b8fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b8fd, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b900, 5); calld(Definitions.sys_strcpy, 0x7_a5ca); /* call 0x10165ecf */
            ii(0x100e_b905, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_b90a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b90d, 5); calld(0x100e_b5e1, -0x331);             /* call 0x100eb5e1 */
            ii(0x100e_b912, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b915, 4); mov(memb_a32[ds, eax + 0x2b], 0x1);     /* mov byte [eax+0x2b], 0x1 */
            ii(0x100e_b919, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b91c, 5); calld(0x100e_b6bf, -0x262);             /* call 0x100eb6bf */
        l_0x100e_b921:
            ii(0x100e_b921, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b923, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b924, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b925, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b926, 1); popd(edx);                              /* pop edx */
            ii(0x100e_b927, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b928, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b929, 1); retd(); return;                         /* ret */
        }
    }
}
