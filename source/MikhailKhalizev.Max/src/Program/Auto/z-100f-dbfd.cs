using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_dbfd-f94e883a")]
        public void Method_100f_dbfd()
        {
            ii(0x100f_dbfd, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_dc02, 5); call(Definitions.sys_check_available_stack_size, 0x6_814b); /* call 0x10165d52 */
            ii(0x100f_dc07, 1); push(ebx);                              /* push ebx */
            ii(0x100f_dc08, 1); push(ecx);                              /* push ecx */
            ii(0x100f_dc09, 1); push(edx);                              /* push edx */
            ii(0x100f_dc0a, 1); push(esi);                              /* push esi */
            ii(0x100f_dc0b, 1); push(edi);                              /* push edi */
            ii(0x100f_dc0c, 1); push(ebp);                              /* push ebp */
            ii(0x100f_dc0d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_dc0f, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100f_dc15, 7); mov(memb[ds, 0x101c_388b], 0);          /* mov byte [0x101c388b], 0x0 */
            ii(0x100f_dc1c, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_dc23, 2); jmp(0x100f_dc2b, 6); goto l_0x100f_dc2b; /* jmp 0x100fdc2b */
        l_0x100f_dc25:
            ii(0x100f_dc25, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_dc28, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x100f_dc2b:
            ii(0x100f_dc2b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dc2f, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100f_dc32, 2); if(jge(0x100f_dc56, 0x22)) goto l_0x100f_dc56; /* jge 0x100fdc56 */
            ii(0x100f_dc34, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dc38, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_dc3e, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_dc44, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_dc49, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100f_dc4c, 2); if(jnz(0x100f_dc54, 6)) goto l_0x100f_dc54; /* jnz 0x100fdc54 */
            ii(0x100f_dc4e, 6); inc(memb[ds, 0x101c_388b]);             /* inc byte [0x101c388b] */
        l_0x100f_dc54:
            ii(0x100f_dc54, 2); jmp(0x100f_dc25, -0x31); goto l_0x100f_dc25; /* jmp 0x100fdc25 */
        l_0x100f_dc56:
            ii(0x100f_dc56, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_dc58, 5); mov(al, memb[ds, 0x101c_388b]);         /* mov al, [0x101c388b] */
            ii(0x100f_dc5d, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100f_dc60, 2); if(jg(0x100f_dc6b, 9)) goto l_0x100f_dc6b; /* jg 0x100fdc6b */
            ii(0x100f_dc62, 7); mov(memb[ds, 0x101c_388b], 0);          /* mov byte [0x101c388b], 0x0 */
            ii(0x100f_dc69, 2); jmp(0x100f_dc72, 7); goto l_0x100f_dc72; /* jmp 0x100fdc72 */
        l_0x100f_dc6b:
            ii(0x100f_dc6b, 7); mov(memb[ds, 0x101c_37c9], 0);          /* mov byte [0x101c37c9], 0x0 */
        l_0x100f_dc72:
            ii(0x100f_dc72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_dc74, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_dc75, 1); pop(edi);                               /* pop edi */
            ii(0x100f_dc76, 1); pop(esi);                               /* pop esi */
            ii(0x100f_dc77, 1); pop(edx);                               /* pop edx */
            ii(0x100f_dc78, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_dc79, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_dc7a, 1); ret();                                  /* ret */
        }
    }
}
