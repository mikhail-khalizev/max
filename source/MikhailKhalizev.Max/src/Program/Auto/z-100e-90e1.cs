using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa0314ce-7171-4863-a7b2-f5bdb0f4dcb2")]
        public void Method_100e_90e1()
        {
            ii(0x100e_90e1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_90e6, 5); calld(Definitions.sys_check_available_stack_size, 0x7_cc67); /* call 0x10165d52 */
            ii(0x100e_90eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_90ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_90ed, 1); pushd(esi);                             /* push esi */
            ii(0x100e_90ee, 1); pushd(edi);                             /* push edi */
            ii(0x100e_90ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_90f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_90f2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_90f8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_90fb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_90fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9101, 7); mov(memd_a32[ds, eax + 0x27], 0);       /* mov dword [eax+0x27], 0x0 */
            ii(0x100e_9108, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_910b, 7); mov(memd_a32[ds, eax + 0x2b], 0);       /* mov dword [eax+0x2b], 0x0 */
            ii(0x100e_9112, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9115, 7); mov(memd_a32[ds, eax + 0x2f], 0);       /* mov dword [eax+0x2f], 0x0 */
            ii(0x100e_911c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_911f, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x100e_9123, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9126, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x100e_912a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_912d, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_9130, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9133, 5); calld(Definitions.my_get_res_data_by_id, 0x4_aea0); /* call 0x10133fd8 */
            ii(0x100e_9138, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_913a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_913d, 3); mov(memd_a32[ds, eax + 0x6], edx);      /* mov [eax+0x6], edx */
            ii(0x100e_9140, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9143, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_9145, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9148, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100e_914a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_914d, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x100e_9151, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9154, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x100e_9158, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_915b, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x100e_915f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9162, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x100e_9166, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9169, 4); mov(dx, memw_a32[ds, eax + 0xe]);       /* mov dx, [eax+0xe] */
            ii(0x100e_916d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9170, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x100e_9174, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9177, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x100e_917b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_917e, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x100e_9182, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9185, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100e_9189, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_918c, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x100e_9190, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9193, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x100e_9196, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_9199, 3); mov(memb_a32[ds, edx + 0x14], al);      /* mov [edx+0x14], al */
            ii(0x100e_919c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_919f, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x100e_91a2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91a5, 3); mov(memd_a32[ds, edx + 0x17], eax);     /* mov [edx+0x17], eax */
            ii(0x100e_91a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_91ab, 3); mov(al, memb_a32[ds, eax + 0x15]);      /* mov al, [eax+0x15] */
            ii(0x100e_91ae, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91b1, 3); mov(memb_a32[ds, edx + 0x15], al);      /* mov [edx+0x15], al */
            ii(0x100e_91b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_91b7, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100e_91ba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91bd, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x100e_91c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_91c3, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100e_91c6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91c9, 3); mov(memd_a32[ds, edx + 0x1f], eax);     /* mov [edx+0x1f], eax */
            ii(0x100e_91cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_91cf, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_91d2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91d5, 3); mov(memd_a32[ds, edx + 0x23], eax);     /* mov [edx+0x23], eax */
            ii(0x100e_91d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_91db, 3); mov(al, memb_a32[ds, eax + 0x16]);      /* mov al, [eax+0x16] */
            ii(0x100e_91de, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_91e1, 3); mov(memb_a32[ds, edx + 0x16], al);      /* mov [edx+0x16], al */
            ii(0x100e_91e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_91e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_91e7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_91e8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_91e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_91ea, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_91eb, 1); retd(); return;                         /* ret */
        }
    }
}
