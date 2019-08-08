using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b12b7053-bc54-47b8-b2dd-5fe3eba85e52")]
        public void Method_100d_811c()
        {
            ii(0x100d_811c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_8121, 5); calld(Definitions.sys_check_available_stack_size, 0x8_dc2c); /* call 0x10165d52 */
            ii(0x100d_8126, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8127, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8128, 1); pushd(edx);                             /* push edx */
            ii(0x100d_8129, 1); pushd(esi);                             /* push esi */
            ii(0x100d_812a, 1); pushd(edi);                             /* push edi */
            ii(0x100d_812b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_812c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_812e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_8134, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_8137, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_813a, 4); cmp(memb_a32[ds, eax + 0xc], 0);        /* cmp byte [eax+0xc], 0x0 */
            ii(0x100d_813e, 2); if(jnzd(0x100d_818e, 0x4e)) goto l_0x100d_818e; /* jnz 0x100d818e */
            ii(0x100d_8140, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8143, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_8146, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_8149, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_814c, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100d_814f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8152, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_8155, 5); calld(Definitions.sys_new_arr, 0x8_deb6); /* call 0x10166010 */
            ii(0x100d_815a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_815d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8160, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_8163, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_8166, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8169, 3); mov(ebx, memd_a32[ds, eax + 0x8]);      /* mov ebx, [eax+0x8] */
            ii(0x100d_816c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_816f, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100d_8172, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8175, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100d_8177, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_817a, 5); calld(Definitions.sys_memcpy, 0x8_dccc); /* call 0x10165e4b */
            ii(0x100d_817f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_8182, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_8185, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x100d_8187, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_818a, 4); mov(memb_a32[ds, eax + 0xc], 0x1);      /* mov byte [eax+0xc], 0x1 */
        l_0x100d_818e:
            ii(0x100d_818e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8190, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8191, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8192, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8193, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8194, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8195, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8196, 1); retd(); return;                         /* ret */
        }
    }
}
