using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_92fd-f5739bfd")]
        public void Method_100a_92fd()
        {
            ii(0x100a_92fd, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_9302, 5); call(Definitions.sys_check_available_stack_size, 0xb_ca4b); /* call 0x10165d52 */
            ii(0x100a_9307, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9308, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9309, 1); push(edx);                              /* push edx */
            ii(0x100a_930a, 1); push(esi);                              /* push esi */
            ii(0x100a_930b, 1); push(edi);                              /* push edi */
            ii(0x100a_930c, 1); push(ebp);                              /* push ebp */
            ii(0x100a_930d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_930f, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_9315, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_9318, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_931f, 2); jmp(0x100a_9327, 6); goto l_0x100a_9327; /* jmp 0x100a9327 */
        l_0x100a_9321:
            ii(0x100a_9321, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_9324, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100a_9327:
            ii(0x100a_9327, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_932b, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100a_932e, 2); if(jge(0x100a_938c, 0x5c)) goto l_0x100a_938c; /* jge 0x100a938c */
            ii(0x100a_9330, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9333, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_9336, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_933b, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_933f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_9341, 2); if(jz(0x100a_935d, 0x1a)) goto l_0x100a_935d; /* jz 0x100a935d */
            ii(0x100a_9343, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9347, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_934d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_9353, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9358, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_935b, 2); if(jz(0x100a_935f, 2)) goto l_0x100a_935f; /* jz 0x100a935f */
        l_0x100a_935d:
            ii(0x100a_935d, 2); jmp(0x100a_936f, 0x10); goto l_0x100a_936f; /* jmp 0x100a936f */
        l_0x100a_935f:
            ii(0x100a_935f, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_9363, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9366, 5); call(0x1007_6074, -0x3_32f7);           /* call 0x10076074 */
            ii(0x100a_936b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_936d, 2); if(jnz(0x100a_9371, 2)) goto l_0x100a_9371; /* jnz 0x100a9371 */
        l_0x100a_936f:
            ii(0x100a_936f, 2); jmp(0x100a_938a, 0x19); goto l_0x100a_938a; /* jmp 0x100a938a */
        l_0x100a_9371:
            ii(0x100a_9371, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9374, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9378, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_937e, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_9383, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_9385, 5); call(0x100c_2be5, 0x1_985b);            /* call 0x100c2be5 */
        l_0x100a_938a:
            ii(0x100a_938a, 2); jmp(0x100a_9321, -0x6b); goto l_0x100a_9321; /* jmp 0x100a9321 */
        l_0x100a_938c:
            ii(0x100a_938c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_938e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_938f, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9390, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9391, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9392, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9393, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9394, 1); ret();                                  /* ret */
        }
    }
}
