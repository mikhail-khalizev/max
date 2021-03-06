using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f1f2-3b5ae5ae")]
        public void Method_1014_f1f2()
        {
            ii(0x1014_f1f2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_f1f7, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6b56);/* call 0x10165d52 */
            ii(0x1014_f1fc, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_f1fd, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_f1fe, 1);  push(edx);                            /* push edx */
            ii(0x1014_f1ff, 1);  push(esi);                            /* push esi */
            ii(0x1014_f200, 1);  push(edi);                            /* push edi */
            ii(0x1014_f201, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f202, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f204, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_f20a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_f20d, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_f214, 2);  jmp(0x1014_f21c, 6); goto l_0x1014_f21c;/* jmp 0x1014f21c */
        l_0x1014_f216:
            ii(0x1014_f216, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f219, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1014_f21c:
            ii(0x1014_f21c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_f220, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x1014_f223, 2);  if(jge(0x1014_f284, 0x5f)) goto l_0x1014_f284;/* jge 0x1014f284 */
            ii(0x1014_f225, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f228, 5);  cmp(memw[ds, eax + 8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x1014_f22d, 2);  if(jz(0x1014_f239, 0xa)) goto l_0x1014_f239;/* jz 0x1014f239 */
            ii(0x1014_f22f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f232, 5);  cmp(memw[ds, eax + 8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x1014_f237, 2);  if(jnz(0x1014_f23b, 2)) goto l_0x1014_f23b;/* jnz 0x1014f23b */
        l_0x1014_f239:
            ii(0x1014_f239, 2);  jmp(0x1014_f245, 0xa); goto l_0x1014_f245;/* jmp 0x1014f245 */
        l_0x1014_f23b:
            ii(0x1014_f23b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f23e, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f243, 2);  if(jnz(0x1014_f247, 2)) goto l_0x1014_f247;/* jnz 0x1014f247 */
        l_0x1014_f245:
            ii(0x1014_f245, 2);  jmp(0x1014_f251, 0xa); goto l_0x1014_f251;/* jmp 0x1014f251 */
        l_0x1014_f247:
            ii(0x1014_f247, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f24a, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1014_f24f, 2);  if(jnz(0x1014_f261, 0x10)) goto l_0x1014_f261;/* jnz 0x1014f261 */
        l_0x1014_f251:
            ii(0x1014_f251, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_f255, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1014_f258, 7);  mov(memb[ds, eax + 171], 0);          /* mov byte [eax+0xab], 0x0 */
            ii(0x1014_f25f, 2);  jmp(0x1014_f274, 0x13); goto l_0x1014_f274;/* jmp 0x1014f274 */
        l_0x1014_f261:
            ii(0x1014_f261, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_f265, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1014_f268, 6);  mov(dl, memb[ds, 0x101c_3920]);       /* mov dl, [0x101c3920] */
            ii(0x1014_f26e, 6);  mov(memb[ds, eax + 171], dl);         /* mov [eax+0xab], dl */
        l_0x1014_f274:
            ii(0x1014_f274, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_f278, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1014_f27b, 7);  mov(memb[ds, eax + 176], 0);          /* mov byte [eax+0xb0], 0x0 */
            ii(0x1014_f282, 2);  jmp(0x1014_f216, -0x6e); goto l_0x1014_f216;/* jmp 0x1014f216 */
        l_0x1014_f284:
            ii(0x1014_f284, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f287, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_f28a, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f28f, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1014_f292, 7);  mov(memb[ds, eax + 171], 1);          /* mov byte [eax+0xab], 0x1 */
            ii(0x1014_f299, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_f29b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_f29c, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_f29d, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_f29e, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_f29f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_f2a0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_f2a1, 1);  ret();                                /* ret */
        }
    }
}
