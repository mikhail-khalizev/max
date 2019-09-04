using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0ace-a7aa1133")]
        public void /* sys */ Method_1018_0ace()
        {
            ii(0x1018_0ace, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_0acf, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_0ad0, 1);  push(esi);                            /* push esi */
            ii(0x1018_0ad1, 1);  push(edi);                            /* push edi */
            ii(0x1018_0ad2, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_0ad3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1018_0ad5, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1018_0adb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1018_0ade, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1018_0ae1, 7);  imul(edx, memd[ss, ebp - 16], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0ae8, 4);  imul(eax, memd[ss, ebp - 12], 6);     /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0aec, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1018_0aee, 7);  lgs(eax, memd[ds, eax + 0x1020_b718]);/* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0af5, 5);  movsx(eax, memw[gs, eax + 48]);       /* movsx eax, word [gs:eax+0x30] */
            ii(0x1018_0afa, 3);  test(ah, 0x80);                       /* test ah, 0x80 */
            ii(0x1018_0afd, 2);  if(jz(0x1018_0b1d, 0x1e)) goto l_0x1018_0b1d;/* jz 0x10180b1d */
            ii(0x1018_0aff, 7);  imul(edx, memd[ss, ebp - 16], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0b06, 4);  imul(eax, memd[ss, ebp - 12], 6);     /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0b0a, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1018_0b0c, 7);  lgs(eax, memd[ds, eax + 0x1020_b718]);/* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0b13, 5);  movsx(eax, memw[gs, eax + 84]);       /* movsx eax, word [gs:eax+0x54] */
            ii(0x1018_0b18, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1018_0b1b, 2);  jmp(0x1018_0b26, 9); goto l_0x1018_0b26;/* jmp 0x10180b26 */
        l_0x1018_0b1d:
            ii(0x1018_0b1d, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1018_0b24, 2);  jmp(0x1018_0b2c, 6); goto l_0x1018_0b2c;/* jmp 0x10180b2c */
        l_0x1018_0b26:
            ii(0x1018_0b26, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1018_0b29, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1018_0b2c:
            ii(0x1018_0b2c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1018_0b2f, 1);  leave();                              /* leave */
            ii(0x1018_0b30, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_0b31, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_0b32, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_0b33, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_0b34, 1);  ret();                                /* ret */
        }
    }
}
