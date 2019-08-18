using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4157-4c33ee52")]
        public void Method_1013_4157()
        {
            ii(0x1013_4157, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_415c, 5); calld(Definitions.sys_check_available_stack_size, 0x3_1bf1); /* call 0x10165d52 */
            ii(0x1013_4161, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_4162, 1); pushd(esi);                             /* push esi */
            ii(0x1013_4163, 1); pushd(edi);                             /* push edi */
            ii(0x1013_4164, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_4165, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4167, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_416d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_4170, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_4173, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_4176, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_417a, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_417d, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4182, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4184, 4); cmp(memd_a32[ds, eax + 0x2], 0);        /* cmp dword [eax+0x2], 0x0 */
            ii(0x1013_4188, 2); if(jzd(0x1013_41c6, 0x3c)) goto l_0x1013_41c6; /* jz 0x101341c6 */
            ii(0x1013_418a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_418e, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4191, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4196, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4198, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1013_419b, 5); calld(Definitions.sys_delete, 0x3_1dc4); /* call 0x10165f64 */
            ii(0x1013_41a0, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_41a4, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_41a7, 6); mov(edx, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_41ad, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_41af, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_41b2, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1013_41b5, 6); mov(edx, memd_a32[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_41bb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_41bd, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1013_41c0, 6); sub(memd_a32[ds, 0x101c_70dc], eax);    /* sub [0x101c70dc], eax */
        l_0x1013_41c6:
            ii(0x1013_41c6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_41ca, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_41cd, 6); mov(edx, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_41d3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_41d5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_41d8, 3); mov(memd_a32[ds, edx + 0x2], eax);      /* mov [edx+0x2], eax */
            ii(0x1013_41db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_41de, 6); add(memd_a32[ds, 0x101c_70dc], eax);    /* add [0x101c70dc], eax */
            ii(0x1013_41e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_41e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_41e7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_41e8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_41e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_41ea, 1); retd(); return;                         /* ret */
        }
    }
}
