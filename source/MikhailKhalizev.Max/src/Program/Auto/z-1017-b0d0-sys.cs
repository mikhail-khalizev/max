using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_b0d0-342414eb")]
        public void /* sys */ Method_1017_b0d0()
        {
            ii(0x1017_b0d0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_b0d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b0d3, 1); push(esi);                              /* push esi */
            ii(0x1017_b0d4, 1); push(edi);                              /* push edi */
            ii(0x1017_b0d5, 6); sub(esp, 0xb0);                         /* sub esp, 0xb0 */
            ii(0x1017_b0db, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_b0dd, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_b0df, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1017_b0e2, 3); mov(edx, memd[ss, ebp + 0x30]);         /* mov edx, [ebp+0x30] */
            ii(0x1017_b0e5, 1); push(edx);                              /* push edx */
            ii(0x1017_b0e6, 3); mov(ebx, memd[ss, ebp + 0x2c]);         /* mov ebx, [ebp+0x2c] */
            ii(0x1017_b0e9, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b0ea, 3); mov(eax, memd[ss, ebp + 0x28]);         /* mov eax, [ebp+0x28] */
            ii(0x1017_b0ed, 1); push(eax);                              /* push eax */
            ii(0x1017_b0ee, 3); mov(edx, memd[ss, ebp + 0x24]);         /* mov edx, [ebp+0x24] */
            ii(0x1017_b0f1, 1); push(edx);                              /* push edx */
            ii(0x1017_b0f2, 3); mov(ebx, memd[ss, ebp + 0x20]);         /* mov ebx, [ebp+0x20] */
            ii(0x1017_b0f5, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b0f6, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1017_b0f9, 1); push(eax);                              /* push eax */
            ii(0x1017_b0fa, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x1017_b0fd, 1); push(edx);                              /* push edx */
            ii(0x1017_b0fe, 3); mov(ebx, memd[ss, ebp + 0x14]);         /* mov ebx, [ebp+0x14] */
            ii(0x1017_b101, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b102, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1017_b105, 1); push(eax);                              /* push eax */
            ii(0x1017_b106, 3); mov(edx, memd[ss, ebp + 0xc]);          /* mov edx, [ebp+0xc] */
            ii(0x1017_b109, 1); push(edx);                              /* push edx */
            ii(0x1017_b10a, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1017_b10d, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b10e, 6); lea(eax, memd[ss, ebp - 0xb8]);         /* lea eax, [ebp-0xb8] */
            ii(0x1017_b114, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_b116, 1); push(ecx);                              /* push ecx */
            ii(0x1017_b117, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_b119, 3); mov(ecx, memd[ss, ebp - 0xc]);          /* mov ecx, [ebp-0xc] */
            ii(0x1017_b11c, 5); call(/* sys */ 0x1017_af00, -0x221);    /* call 0x1017af00 */
            ii(0x1017_b121, 6); lea(eax, memd[ss, ebp - 0xb8]);         /* lea eax, [ebp-0xb8] */
            ii(0x1017_b127, 5); call(/* sys */ 0x1017_ac90, -0x49c);    /* call 0x1017ac90 */
            ii(0x1017_b12c, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1017_b12f, 1); pop(edi);                               /* pop edi */
            ii(0x1017_b130, 1); pop(esi);                               /* pop esi */
            ii(0x1017_b131, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b132, 3); ret(0x2c);                              /* ret 0x2c */
        }
    }
}
