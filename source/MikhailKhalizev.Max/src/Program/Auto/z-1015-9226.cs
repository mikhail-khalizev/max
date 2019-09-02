using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9226-849033aa")]
        public void Method_1015_9226()
        {
            ii(0x1015_9226, 5); push(0x30);                             /* push 0x30 */
            ii(0x1015_922b, 5); call(Definitions.sys_check_available_stack_size, 0xcb22); /* call 0x10165d52 */
            ii(0x1015_9230, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9231, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9232, 1); push(esi);                              /* push esi */
            ii(0x1015_9233, 1); push(edi);                              /* push edi */
            ii(0x1015_9234, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9235, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9237, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_923d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_9240, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_9243, 5); mov(eax, 0x1015_91d8);                  /* mov eax, 0x101591d8 */
            ii(0x1015_9248, 1); push(eax);                              /* push eax */
            ii(0x1015_9249, 7); mov(memd[ss, ebp - 0x14], 0x31);        /* mov dword [ebp-0x14], 0x31 */
            ii(0x1015_9250, 5); mov(eax, StringDefinitions.Repair3);    /* mov eax, 0x101b259f */
            ii(0x1015_9255, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_9258, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_925b, 4); cmp(memb[ds, eax + 0x57], 4);           /* cmp byte [eax+0x57], 0x4 */
            ii(0x1015_925f, 2); if(jnz(0x1015_9267, 6)) goto l_0x1015_9267; /* jnz 0x10159267 */
            ii(0x1015_9261, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_9265, 2); jmp(0x1015_926b, 4); goto l_0x1015_926b; /* jmp 0x1015926b */
        l_0x1015_9267:
            ii(0x1015_9267, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_926b:
            ii(0x1015_926b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_926d, 3); mov(dl, memb[ss, ebp - 0xc]);           /* mov dl, [ebp-0xc] */
            ii(0x1015_9270, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9273, 3); mov(ecx, memd[ss, ebp - 0x14]);         /* mov ecx, [ebp-0x14] */
            ii(0x1015_9276, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1015_9279, 5); call(0x1015_7ccf, -0x15af);             /* call 0x10157ccf */
            ii(0x1015_927e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_9281, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9284, 5); call(0x1015_8bbb, -0x6ce);              /* call 0x10158bbb */
            ii(0x1015_9289, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_928b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_928c, 1); pop(edi);                               /* pop edi */
            ii(0x1015_928d, 1); pop(esi);                               /* pop esi */
            ii(0x1015_928e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_928f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9290, 1); ret();                                  /* ret */
        }
    }
}
