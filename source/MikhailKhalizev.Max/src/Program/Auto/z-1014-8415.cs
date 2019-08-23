using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8415-cdbcb63d")]
        public void Method_1014_8415()
        {
            ii(0x1014_8415, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_841a, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d933); /* call 0x10165d52 */
            ii(0x1014_841f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8420, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8421, 1); pushd(edx);                             /* push edx */
            ii(0x1014_8422, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8423, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8424, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8425, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8427, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_842d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8430, 5); calld(Definitions.sys_cli, 0x3_8ba5);   /* call 0x10180fda */
            ii(0x1014_8435, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x1014_843a, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1014_843f, 5); calld(Definitions.sys_write_port, 0x3_8b84); /* call 0x10180fc8 */
            ii(0x1014_8444, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_8447, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_844d, 5); mov(eax, 0x40);                         /* mov eax, 0x40 */
            ii(0x1014_8452, 5); calld(Definitions.sys_write_port, 0x3_8b71); /* call 0x10180fc8 */
            ii(0x1014_8457, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_845a, 3); sar(edx, 0x8);                          /* sar edx, 0x8 */
            ii(0x1014_845d, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_8463, 5); mov(eax, 0x40);                         /* mov eax, 0x40 */
            ii(0x1014_8468, 5); calld(Definitions.sys_write_port, 0x3_8b5b); /* call 0x10180fc8 */
            ii(0x1014_846d, 5); calld(Definitions.sys_sti, 0x3_8b6a);   /* call 0x10180fdc */
            ii(0x1014_8472, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8474, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8475, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8476, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8477, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8478, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8479, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_847a, 1); retd();                                 /* ret */
        }
    }
}
