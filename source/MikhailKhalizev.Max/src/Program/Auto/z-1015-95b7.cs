using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_95b7-5e922a92")]
        public void Method_1015_95b7()
        {
            ii(0x1015_95b7, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_95bc, 5); call(Definitions.sys_check_available_stack_size, 0xc791); /* call 0x10165d52 */
            ii(0x1015_95c1, 1); push(ebx);                              /* push ebx */
            ii(0x1015_95c2, 1); push(ecx);                              /* push ecx */
            ii(0x1015_95c3, 1); push(esi);                              /* push esi */
            ii(0x1015_95c4, 1); push(edi);                              /* push edi */
            ii(0x1015_95c5, 1); push(ebp);                              /* push ebp */
            ii(0x1015_95c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_95c8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_95ce, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_95d1, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_95d4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_95d7, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1015_95db, 2); if(jnz(0x1015_95ec, 0xf)) goto l_0x1015_95ec; /* jnz 0x101595ec */
            ii(0x1015_95dd, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_95e0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_95e2, 5); call(0x1015_944a, -0x19d);              /* call 0x1015944a */
            ii(0x1015_95e7, 5); jmp(0x1015_9678, 0x8c); goto l_0x1015_9678; /* jmp 0x10159678 */
        l_0x1015_95ec:
            ii(0x1015_95ec, 5); mov(eax, 0x1015_93da);                  /* mov eax, 0x101593da */
            ii(0x1015_95f1, 1); push(eax);                              /* push eax */
            ii(0x1015_95f2, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_95f7, 5); mov(ebx, StringDefinitions.Build3);     /* mov ebx, 0x101b25fc */
            ii(0x1015_95fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_95fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9601, 5); call(0x1015_7ccf, -0x1937);             /* call 0x10157ccf */
            ii(0x1015_9606, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9609, 4); cmp(memb[ds, eax + 0x3d], 0x15);        /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1015_960d, 2); if(jz(0x1015_9618, 0x9)) goto l_0x1015_9618; /* jz 0x10159618 */
            ii(0x1015_960f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9612, 4); cmp(memb[ds, eax + 0x3d], 0x1f);        /* cmp byte [eax+0x3d], 0x1f */
            ii(0x1015_9616, 2); if(jnz(0x1015_9634, 0x1c)) goto l_0x1015_9634; /* jnz 0x10159634 */
        l_0x1015_9618:
            ii(0x1015_9618, 5); mov(eax, 0x1015_9572);                  /* mov eax, 0x10159572 */
            ii(0x1015_961d, 1); push(eax);                              /* push eax */
            ii(0x1015_961e, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1015_9623, 5); mov(ebx, StringDefinitions.Start);      /* mov ebx, 0x101b2602 */
            ii(0x1015_9628, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_962a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_962d, 5); call(0x1015_7ccf, -0x1963);             /* call 0x10157ccf */
            ii(0x1015_9632, 2); jmp(0x1015_966d, 0x39); goto l_0x1015_966d; /* jmp 0x1015966d */
        l_0x1015_9634:
            ii(0x1015_9634, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9637, 4); cmp(memb[ds, eax + 0x3d], 0x4);         /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_963b, 2); if(jnz(0x1015_9646, 0x9)) goto l_0x1015_9646; /* jnz 0x10159646 */
            ii(0x1015_963d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9640, 4); cmp(memb[ds, eax + 0x3e], 0xd);         /* cmp byte [eax+0x3e], 0xd */
            ii(0x1015_9644, 2); if(jnz(0x1015_9648, 0x2)) goto l_0x1015_9648; /* jnz 0x10159648 */
        l_0x1015_9646:
            ii(0x1015_9646, 2); jmp(0x1015_9651, 0x9); goto l_0x1015_9651; /* jmp 0x10159651 */
        l_0x1015_9648:
            ii(0x1015_9648, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_964b, 4); cmp(memb[ds, eax + 0x3e], 0x2e);        /* cmp byte [eax+0x3e], 0x2e */
            ii(0x1015_964f, 2); if(jnz(0x1015_9653, 0x2)) goto l_0x1015_9653; /* jnz 0x10159653 */
        l_0x1015_9651:
            ii(0x1015_9651, 2); jmp(0x1015_966d, 0x1a); goto l_0x1015_966d; /* jmp 0x1015966d */
        l_0x1015_9653:
            ii(0x1015_9653, 5); mov(eax, 0x1015_952d);                  /* mov eax, 0x1015952d */
            ii(0x1015_9658, 1); push(eax);                              /* push eax */
            ii(0x1015_9659, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_965e, 5); mov(ebx, StringDefinitions.Stop3);      /* mov ebx, 0x101b2608 */
            ii(0x1015_9663, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9665, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9668, 5); call(0x1015_7ccf, -0x199e);             /* call 0x10157ccf */
        l_0x1015_966d:
            ii(0x1015_966d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9670, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9673, 5); call(0x1015_8bbb, -0xabd);              /* call 0x10158bbb */
        l_0x1015_9678:
            ii(0x1015_9678, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_967a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_967b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_967c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_967d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_967e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_967f, 1); ret();                                  /* ret */
        }
    }
}
