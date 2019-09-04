using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_58f2-ac318586")]
        public void Method_1014_58f2()
        {
            ii(0x1014_58f2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_58f7, 5); call(Definitions.sys_check_available_stack_size, 0x2_0456); /* call 0x10165d52 */
            ii(0x1014_58fc, 1); push(ebx);                              /* push ebx */
            ii(0x1014_58fd, 1); push(ecx);                              /* push ecx */
            ii(0x1014_58fe, 1); push(esi);                              /* push esi */
            ii(0x1014_58ff, 1); push(edi);                              /* push edi */
            ii(0x1014_5900, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5901, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5903, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_5909, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_590c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_590f, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_5913, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5916, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_5919, 5); call(0x1014_581c, -0x102);              /* call 0x1014581c */
            ii(0x1014_591e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_5921, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_5925, 2); if(jnz(0x1014_5930, 9)) goto l_0x1014_5930; /* jnz 0x10145930 */
            ii(0x1014_5927, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_592e, 2); jmp(0x1014_593b, 0xb); goto l_0x1014_593b; /* jmp 0x1014593b */
        l_0x1014_5930:
            ii(0x1014_5930, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_5933, 5); call(0x1014_7c48, 0x2310);              /* call 0x10147c48 */
            ii(0x1014_5938, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1014_593b:
            ii(0x1014_593b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_593e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5940, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5941, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5942, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5943, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5944, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_5945, 1); ret();                                  /* ret */
        }
    }
}
