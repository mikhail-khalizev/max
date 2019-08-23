using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_ff36-ce6c55db")]
        public void Method_1014_ff36()
        {
            ii(0x1014_ff36, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_ff3b, 5); call(Definitions.sys_check_available_stack_size, 0x1_5e12); /* call 0x10165d52 */
            ii(0x1014_ff40, 1); push(ebx);                              /* push ebx */
            ii(0x1014_ff41, 1); push(ecx);                              /* push ecx */
            ii(0x1014_ff42, 1); push(edx);                              /* push edx */
            ii(0x1014_ff43, 1); push(esi);                              /* push esi */
            ii(0x1014_ff44, 1); push(edi);                              /* push edi */
            ii(0x1014_ff45, 1); push(ebp);                              /* push ebp */
            ii(0x1014_ff46, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_ff48, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_ff4e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_ff51, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ff54, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_ff57, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_ff5a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_ff5d, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x3);  /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x1014_ff64, 2); if(jz(0x1014_ff6f, 0x9)) goto l_0x1014_ff6f; /* jz 0x1014ff6f */
            ii(0x1014_ff66, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_ff6d, 2); jmp(0x1014_ffb8, 0x49); goto l_0x1014_ffb8; /* jmp 0x1014ffb8 */
        l_0x1014_ff6f:
            ii(0x1014_ff6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ff71, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ff74, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ff77, 5); call(0x1013_ad11, -0x1_526b);           /* call 0x1013ad11 */
            ii(0x1014_ff7c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ff7e, 2); if(jz(0x1014_ff8c, 0xc)) goto l_0x1014_ff8c; /* jz 0x1014ff8c */
            ii(0x1014_ff80, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ff83, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1014_ff87, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_ff8a, 2); jmp(0x1014_ffb8, 0x2c); goto l_0x1014_ffb8; /* jmp 0x1014ffb8 */
        l_0x1014_ff8c:
            ii(0x1014_ff8c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_ff8f, 5); call(0x1007_20b1, -0xd_dee3);           /* call 0x100720b1 */
            ii(0x1014_ff94, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1014_ff97, 5); call(0x1007_20b1, -0xd_deeb);           /* call 0x100720b1 */
            ii(0x1014_ff9c, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1014_ff9f, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1014_ffa2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ffa5, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ffa8, 5); call(0x1007_68e0, -0xd_96cd);           /* call 0x100768e0 */
            ii(0x1014_ffad, 5); call(0x1014_3616, -0xc99c);             /* call 0x10143616 */
            ii(0x1014_ffb2, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_ffb5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_ffb8:
            ii(0x1014_ffb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_ffbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_ffbd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_ffbe, 1); pop(edi);                               /* pop edi */
            ii(0x1014_ffbf, 1); pop(esi);                               /* pop esi */
            ii(0x1014_ffc0, 1); pop(edx);                               /* pop edx */
            ii(0x1014_ffc1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_ffc2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_ffc3, 1); ret();                                  /* ret */
        }
    }
}
