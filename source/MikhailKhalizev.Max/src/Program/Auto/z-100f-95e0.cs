using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dec4fcba-bcba-483c-871f-dd9c461baedd")]
        public void Method_100f_95e0()
        {
            ii(0x100f_95e0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_95e5, 5); calld(Definitions.sys_check_available_stack_size, 0x6_c768); /* call 0x10165d52 */
            ii(0x100f_95ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_95eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_95ec, 1); pushd(esi);                             /* push esi */
            ii(0x100f_95ed, 1); pushd(edi);                             /* push edi */
            ii(0x100f_95ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_95ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_95f1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_95f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_95fa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_95fd, 5); mov(eax, 0x53);                         /* mov eax, 0x53 */
            ii(0x100f_9602, 5); calld(0x1007_5fdc, -0x8_362b);          /* call 0x10075fdc */
            ii(0x100f_9607, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_9609, 2); if(jzd(0x100f_9614, 0x9)) goto l_0x100f_9614; /* jz 0x100f9614 */
            ii(0x100f_960b, 7); test(memb_a32[ds, 0x101c_38d4], 0x1);   /* test byte [0x101c38d4], 0x1 */
            ii(0x100f_9612, 2); if(jzd(0x100f_9616, 0x2)) goto l_0x100f_9616; /* jz 0x100f9616 */
        l_0x100f_9614:
            ii(0x100f_9614, 2); jmpd(0x100f_961f, 0x9); goto l_0x100f_961f; /* jmp 0x100f961f */
        l_0x100f_9616:
            ii(0x100f_9616, 7); cmp(memb_a32[ds, 0x101c_38a2], 0x2);    /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_961d, 2); if(jnzd(0x100f_9621, 0x2)) goto l_0x100f_9621; /* jnz 0x100f9621 */
        l_0x100f_961f:
            ii(0x100f_961f, 2); jmpd(0x100f_9623, 0x2); goto l_0x100f_9623; /* jmp 0x100f9623 */
        l_0x100f_9621:
            ii(0x100f_9621, 2); jmpd(0x100f_9635, 0x12); goto l_0x100f_9635; /* jmp 0x100f9635 */
        l_0x100f_9623:
            ii(0x100f_9623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_9626, 6); mov(memw_a32[ds, 0x101c_3986], ax);     /* mov [0x101c3986], ax */
            ii(0x100f_962c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_962f, 6); mov(memw_a32[ds, 0x101c_3988], ax);     /* mov [0x101c3988], ax */
        l_0x100f_9635:
            ii(0x100f_9635, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_9637, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_9638, 1); popd(edi);                              /* pop edi */
            ii(0x100f_9639, 1); popd(esi);                              /* pop esi */
            ii(0x100f_963a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_963b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_963c, 1); retd(); return;                         /* ret */
        }
    }
}
