using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4263-d112a3bd")]
        public void Method_1012_4263()
        {
            ii(0x1012_4263, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_4268, 5); call(Definitions.sys_check_available_stack_size, 0x4_1ae5); /* call 0x10165d52 */
            ii(0x1012_426d, 1); push(ebx);                              /* push ebx */
            ii(0x1012_426e, 1); push(esi);                              /* push esi */
            ii(0x1012_426f, 1); push(edi);                              /* push edi */
            ii(0x1012_4270, 1); push(ebp);                              /* push ebp */
            ii(0x1012_4271, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4273, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_4279, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_4280, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4283, 1); push(eax);                              /* push eax */
            ii(0x1012_4284, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4287, 1); push(eax);                              /* push eax */
            ii(0x1012_4288, 5); call(0x1012_3850, -0xa3d);              /* call 0x10123850 */
            ii(0x1012_428d, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1012_4290, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4292, 2); if(jnz(0x1012_429d, 9)) goto l_0x1012_429d; /* jnz 0x1012429d */
            ii(0x1012_4294, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_429b, 2); jmp(0x1012_430f, 0x72); goto l_0x1012_430f; /* jmp 0x1012430f */
        l_0x1012_429d:
            ii(0x1012_429d, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_42a0, 6); mov(eax, memd[ds, eax + 0x9c]);         /* mov eax, [eax+0x9c] */
            ii(0x1012_42a6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1012_42a9:
            ii(0x1012_42a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_42ac, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1012_42af, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_42b1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_42b6, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1012_42b9, 2); if(jz(0x1012_42c3, 8)) goto l_0x1012_42c3; /* jz 0x101242c3 */
            ii(0x1012_42bb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_42be, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
            ii(0x1012_42c1, 2); jmp(0x1012_42a9, -0x1a); goto l_0x1012_42a9; /* jmp 0x101242a9 */
        l_0x1012_42c3:
            ii(0x1012_42c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_42c6, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
            ii(0x1012_42c9, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_42cc, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_42d2, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_42d5, 6); mov(eax, memd[ds, eax + 0x88]);         /* mov eax, [eax+0x88] */
            ii(0x1012_42db, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_42dd, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1012_42e0, 3); add(ebx, memd[ss, ebp - 4]);            /* add ebx, [ebp-0x4] */
            ii(0x1012_42e3, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1012_42e5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_42e7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_42ea, 3); add(edx, memd[ss, ebp - 4]);            /* add edx, [ebp-0x4] */
            ii(0x1012_42ed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_42f0, 5); call(/* sys */ 0x1016_6177, 0x4_1e82);  /* call 0x10166177 */
            ii(0x1012_42f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_42f8, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_42fb, 6); sub(memd[ds, edx + 0x88], eax);         /* sub [edx+0x88], eax */
            ii(0x1012_4301, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4304, 4); or(memb[ds, eax + 1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_4308, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_430f:
            ii(0x1012_430f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_4312, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4314, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_4315, 1); pop(edi);                               /* pop edi */
            ii(0x1012_4316, 1); pop(esi);                               /* pop esi */
            ii(0x1012_4317, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_4318, 1); ret();                                  /* ret */
        }
    }
}
