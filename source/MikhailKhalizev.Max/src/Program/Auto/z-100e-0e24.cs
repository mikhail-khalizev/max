using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8fa0a061-c51b-470a-9bf1-17830adcc1d8")]
        public void Method_100e_0e24()
        {
            ii(0x100e_0e24, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0e29, 5); calld(Definitions.sys_check_available_stack_size, 0x8_4f24); /* call 0x10165d52 */
            ii(0x100e_0e2e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0e2f, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0e30, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0e31, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0e32, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0e34, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0e3a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0e3d, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x100e_0e40, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
        l_0x100e_0e43:
            ii(0x100e_0e43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_0e46, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x100e_0e49, 3); cmp(al, memb_a32[ss, ebp - 0x8]);       /* cmp al, [ebp-0x8] */
            ii(0x100e_0e4c, 2); if(jnzd(0x100e_0e63, 0x15)) goto l_0x100e_0e63; /* jnz 0x100e0e63 */
            ii(0x100e_0e4e, 5); calld(0x100d_5094, -0xbdbf);            /* call 0x100d5094 */
            ii(0x100e_0e53, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_0e55, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_0e57, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_0e59, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_0e5c, 5); calld(0x1010_0e32, 0x1_ffd1);           /* call 0x10100e32 */
            ii(0x100e_0e61, 2); jmpd(0x100e_0e43, -0x20); goto l_0x100e_0e43; /* jmp 0x100e0e43 */
        l_0x100e_0e63:
            ii(0x100e_0e63, 5); calld(0x100e_42e4, 0x347c);             /* call 0x100e42e4 */
            ii(0x100e_0e68, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_0e6d, 5); calld(0x1012_8835, 0x4_79c3);           /* call 0x10128835 */
            ii(0x100e_0e72, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_0e74, 2); if(jzd(0x100e_0e63, -0x13)) goto l_0x100e_0e63; /* jz 0x100e0e63 */
            ii(0x100e_0e76, 5); calld(0x1016_2cb8, 0x8_1e3d);           /* call 0x10162cb8 */
            ii(0x100e_0e7b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0e7d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0e7e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0e7f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0e80, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0e81, 1); retd(); return;                         /* ret */
        }
    }
}
