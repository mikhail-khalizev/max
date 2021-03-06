using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_95d0-215e3f92")]
        public void /* sys */ Method_1017_95d0()
        {
            ii(0x1017_95d0, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_95d1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_95d3, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_95d4, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_95d5, 1);  push(esi);                            /* push esi */
            ii(0x1017_95d6, 1);  push(edi);                            /* push edi */
            ii(0x1017_95d7, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_95d9, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1017_95db, 3);  cmp(edi, memd[ds, eax + 4]);          /* cmp edi, [eax+0x4] */
            ii(0x1017_95de, 2);  if(ja(0x1017_95e4, 4)) goto l_0x1017_95e4;/* ja 0x101795e4 */
            ii(0x1017_95e0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1017_95e2, 2);  jmp(0x1017_9640, 0x5c); goto l_0x1017_9640;/* jmp 0x10179640 */
        l_0x1017_95e4:
            ii(0x1017_95e4, 7);  cmp(memd[ds, 0x1020_9dc4], 0);        /* cmp dword [0x10209dc4], 0x0 */
            ii(0x1017_95eb, 2);  if(jz(0x1017_963e, 0x51)) goto l_0x1017_963e;/* jz 0x1017963e */
            ii(0x1017_95ed, 3);  add(edi, 0x64);                       /* add edi, 0x64 */
            ii(0x1017_95f0, 5);  call(/* sys */ 0x1017_94e0, -0x115);  /* call 0x101794e0 */
            ii(0x1017_95f5, 1);  push(edi);                            /* push edi */
            ii(0x1017_95f6, 6);  call_abs(memd[ds, 0x1020_9dc4]);      /* call dword [0x10209dc4] */
            ii(0x1017_95fc, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_95fe, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_9601, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_9603, 2);  if(jz(0x1017_9640, 0x3b)) goto l_0x1017_9640;/* jz 0x10179640 */
            ii(0x1017_9605, 2);  if(jz(0x1017_962c, 0x25)) goto l_0x1017_962c;/* jz 0x1017962c */
            ii(0x1017_9607, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1017_9609, 5);  call(/* sys */ 0x1017_94e0, -0x12e);  /* call 0x101794e0 */
            ii(0x1017_960e, 7);  mov(memd[ds, esi + 8], 0);            /* mov dword [esi+0x8], 0x0 */
            ii(0x1017_9615, 2);  mov(memd[ds, esi], ebx);              /* mov [esi], ebx */
            ii(0x1017_9617, 3);  mov(ecx, memd[ds, esi + 12]);         /* mov ecx, [esi+0xc] */
            ii(0x1017_961a, 3);  mov(memd[ds, esi + 4], edi);          /* mov [esi+0x4], edi */
            ii(0x1017_961d, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1017_961f, 2);  if(jz(0x1017_962c, 0xb)) goto l_0x1017_962c;/* jz 0x1017962c */
            ii(0x1017_9621, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1017_9623, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_9625, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1017_9627, 5);  call(/* sys */ 0x1019_44a0, 0x1_ae74);/* call 0x101944a0 */
        l_0x1017_962c:
            ii(0x1017_962c, 7);  mov(memd[ds, esi + 8], 1);            /* mov dword [esi+0x8], 0x1 */
            ii(0x1017_9633, 2);  mov(eax, memd[ds, esi]);              /* mov eax, [esi] */
            ii(0x1017_9635, 3);  lea(esp, memd[ss, ebp - 16]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_9638, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_9639, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_963a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_963b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_963c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_963d, 1);  ret(); return;                        /* ret */
        l_0x1017_963e:
            ii(0x1017_963e, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1017_9640:
            ii(0x1017_9640, 3);  lea(esp, memd[ss, ebp - 16]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_9643, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_9644, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_9645, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_9646, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_9647, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_9648, 1);  ret();                                /* ret */
        }
    }
}
