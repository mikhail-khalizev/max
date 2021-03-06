using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_08bd-f621961f")]
        public void Method_1009_08bd()
        {
            ii(0x1009_08bd, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_08c2, 5);  call(Definitions.sys_check_available_stack_size, 0xd_548b);/* call 0x10165d52 */
            ii(0x1009_08c7, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_08c8, 1);  push(esi);                            /* push esi */
            ii(0x1009_08c9, 1);  push(edi);                            /* push edi */
            ii(0x1009_08ca, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_08cb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_08cd, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1009_08d3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_08d6, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_08d9, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_08dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_08df, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_08e2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_08e5, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_08e7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_08ea, 3);  mov(edx, memd[ds, eax + 39]);         /* mov edx, [eax+0x27] */
            ii(0x1009_08ed, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1009_08ef, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_08f2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_08f4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_08f7, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1009_08f9, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1009_08fb, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_08fd, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x1009_0900, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_0903:
            ii(0x1009_0903, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0906, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_090a, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1009_090e, 2);  if(jle(0x1009_091b, 0xb)) goto l_0x1009_091b;/* jle 0x1009091b */
            ii(0x1009_0910, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_0913, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_0916, 3);  cmp(eax, 9);                          /* cmp eax, 0x9 */
            ii(0x1009_0919, 2);  if(jz(0x1009_091d, 2)) goto l_0x1009_091d;/* jz 0x1009091d */
        l_0x1009_091b:
            ii(0x1009_091b, 2);  jmp(0x1009_092d, 0x10); goto l_0x1009_092d;/* jmp 0x1009092d */
        l_0x1009_091d:
            ii(0x1009_091d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_0920, 4);  sub(memd[ss, ebp - 16], 2);           /* sub dword [ebp-0x10], 0x2 */
            ii(0x1009_0924, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0927, 4);  dec(memw[ds, eax + 2]);               /* dec word [eax+0x2] */
            ii(0x1009_092b, 2);  jmp(0x1009_0903, -0x2a); goto l_0x1009_0903;/* jmp 0x10090903 */
        l_0x1009_092d:
            ii(0x1009_092d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0930, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_0934, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_0937, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_093a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_093c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_093d, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_093e, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_093f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_0940, 1);  ret();                                /* ret */
        }
    }
}
