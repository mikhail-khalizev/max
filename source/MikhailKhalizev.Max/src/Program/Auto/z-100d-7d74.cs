using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("203dc29e-ffca-4257-9509-acf4c953cbcb")]
        public void Method_100d_7d74()
        {
            ii(0x100d_7d74, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100d_7d79, 5); calld(Definitions.sys_check_available_stack_size, 0x8dfd4); /* call 0x10165d52 */
            ii(0x100d_7d7e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_7d7f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_7d80, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7d81, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7d82, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7d83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7d85, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_7d8b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_7d8e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_7d91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7d94, 5); calld(0x100d_811c, 0x383);              /* call 0x100d811c */
            ii(0x100d_7d99, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7d9c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7d9f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7da2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7da3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7da6, 2); pushd(memd_a32[ds, eax]);               /* push dword [eax] */
            ii(0x100d_7da8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7dab, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100d_7dae, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7db1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7db2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7db5, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100d_7db8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7dbb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7dbc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7dbf, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7dc2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7dc5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7dc6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7dc9, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100d_7dcc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7dcf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7dd2, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100d_7dd5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7dd8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_7ddb, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100d_7ddd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7de0, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100d_7de3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7de6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7de9, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100d_7dec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_7dee, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_7df0, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7df1, 5); calld(/* sys */ 0x1016_abbc, 0x92dc6);  /* call 0x1016abbc */
            ii(0x100d_7df6, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_7df9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7dfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7dfc, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7dfd, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7dfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_7dff, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_7e00, 1); retd(); return;                         /* ret */
        }
    }
}