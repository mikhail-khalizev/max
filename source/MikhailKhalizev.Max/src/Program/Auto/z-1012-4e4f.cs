using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4e4f-adfe38f0")]
        public void Method_1012_4e4f()
        {
            ii(0x1012_4e4f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_4e54, 5); calld(Definitions.sys_check_available_stack_size, 0x4_0ef9); /* call 0x10165d52 */
            ii(0x1012_4e59, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4e5a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4e5b, 1); pushd(edx);                             /* push edx */
            ii(0x1012_4e5c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4e5d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4e5e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4e5f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4e61, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_4e67, 5); calld(0x1012_4e17, -0x55);              /* call 0x10124e17 */
            ii(0x1012_4e6c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4e6e, 2); if(jnzd(0x1012_4e79, 0x9)) goto l_0x1012_4e79; /* jnz 0x10124e79 */
            ii(0x1012_4e70, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_4e77, 2); jmpd(0x1012_4e90, 0x17); goto l_0x1012_4e90; /* jmp 0x10124e90 */
        l_0x1012_4e79:
            ii(0x1012_4e79, 5); mov(eax, 0x5e);                         /* mov eax, 0x5e */
            ii(0x1012_4e7e, 5); calld(0x1012_4dd5, -0xae);              /* call 0x10124dd5 */
            ii(0x1012_4e83, 5); mov(eax, StringDefinitions.Connect);    /* mov eax, 0x101a8186 */
            ii(0x1012_4e88, 5); calld(0x1012_4c13, -0x27a);             /* call 0x10124c13 */
            ii(0x1012_4e8d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1012_4e90:
            ii(0x1012_4e90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_4e93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4e95, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4e96, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4e97, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4e98, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4e99, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4e9a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4e9b, 1); retd();                                 /* ret */
        }
    }
}
