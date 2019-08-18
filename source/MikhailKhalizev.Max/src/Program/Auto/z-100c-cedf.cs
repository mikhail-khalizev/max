using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a0232416-0d90-4637-9db5-c238069dde7c")]
        public void Method_100c_cedf()
        {
            ii(0x100c_cedf, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_cee4, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8e69); /* call 0x10165d52 */
            ii(0x100c_cee9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ceea, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ceeb, 1); pushd(edx);                             /* push edx */
            ii(0x100c_ceec, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ceed, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ceee, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ceef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cef1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_cef7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_cefa, 4); mov(memb_a32[ss, ebp - 0x8], 0x21);     /* mov byte [ebp-0x8], 0x21 */
            ii(0x100c_cefe, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_cf01, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_cf03, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_cf04, 1); popd(edi);                              /* pop edi */
            ii(0x100c_cf05, 1); popd(esi);                              /* pop esi */
            ii(0x100c_cf06, 1); popd(edx);                              /* pop edx */
            ii(0x100c_cf07, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_cf08, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_cf09, 1); retd(); return;                         /* ret */
        }
    }
}
