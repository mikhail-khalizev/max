using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a934f47-22a6-418a-a49c-00294146b9ce")]
        public void Method_1010_6c65()
        {
            ii(0x1010_6c65, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_6c6a, 5); calld(Definitions.sys_check_available_stack_size, 0x5f0e3); /* call 0x10165d52 */
            ii(0x1010_6c6f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6c70, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6c71, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6c72, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6c73, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6c74, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6c75, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6c77, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_6c7d, 5); calld(0x1010_6bb0, -0xd2);              /* call 0x10106bb0 */
            ii(0x1010_6c82, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_6c85, 7); cmp(memd_a32[ss, ebp - 0x4], 0x5b_8d80); /* cmp dword [ebp-0x4], 0x5b8d80 */
            ii(0x1010_6c8c, 2); if(jged(0x1010_6caf, 0x21)) goto l_0x1010_6caf; /* jge 0x10106caf */
            ii(0x1010_6c8e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6c91, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6c92, 5); pushd(0x5b_8d80);                       /* push 0x5b8d80 */
            ii(0x1010_6c97, 5); mov(eax, 0x101a_43d4);                  /* mov eax, 0x101a43d4 */ /* "\nNot enough Extended Memory available to run M.A.X.\nAmount Needed: %i, Amount found: %i\n\n" */
            ii(0x1010_6c9c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6c9d, 5); calld(Definitions.sys_printf, 0x6599a); /* call 0x1016c63c */
            ii(0x1010_6ca2, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_6ca5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_6caa, 5); calld(Definitions.sys_exit, 0x659b0);   /* call 0x1016c65f */
        l_0x1010_6caf:
            ii(0x1010_6caf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6cb1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6cb2, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6cb3, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6cb4, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6cb5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6cb6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6cb7, 1); retd(); return;                         /* ret */
        }
    }
}
