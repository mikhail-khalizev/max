using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_826e-6ef163bc")]
        public void Method_1010_826e()
        {
            ii(0x1010_826e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8273, 5); calld(Definitions.sys_check_available_stack_size, 0x5_dada); /* call 0x10165d52 */
            ii(0x1010_8278, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8279, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_827a, 1); pushd(edx);                             /* push edx */
            ii(0x1010_827b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_827c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_827d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_827e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8280, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_8286, 7); cmp(memb_a32[ds, 0x101c_4dd6], 0);      /* cmp byte [0x101c4dd6], 0x0 */
            ii(0x1010_828d, 2); if(jnzd(0x1010_8298, 0x9)) goto l_0x1010_8298; /* jnz 0x10108298 */
            ii(0x1010_828f, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1010_8296, 2); jmpd(0x1010_82c2, 0x2a); goto l_0x1010_82c2; /* jmp 0x101082c2 */
        l_0x1010_8298:
            ii(0x1010_8298, 7); mov(bx, memw_a32[ds, 0x101c_4dd4]);     /* mov bx, [0x101c4dd4] */
            ii(0x1010_829f, 5); mov(eax, memd_a32[ds, 0x101c_4dd0]);    /* mov eax, [0x101c4dd0] */
            ii(0x1010_82a4, 5); mov(edx, 0x24);                         /* mov edx, 0x24 */
            ii(0x1010_82a9, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1010_82ab, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_82ad, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_82af, 5); calld(/* sys */ 0x1017_92f0, 0x7_103c); /* call 0x101792f0 */
            ii(0x1010_82b4, 7); mov(memb_a32[ds, 0x101c_4dd6], 0);      /* mov byte [0x101c4dd6], 0x0 */
            ii(0x1010_82bb, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_82c2:
            ii(0x1010_82c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_82c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_82c7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_82c8, 1); popd(edi);                              /* pop edi */
            ii(0x1010_82c9, 1); popd(esi);                              /* pop esi */
            ii(0x1010_82ca, 1); popd(edx);                              /* pop edx */
            ii(0x1010_82cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_82cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_82cd, 1); retd();                                 /* ret */
        }
    }
}
