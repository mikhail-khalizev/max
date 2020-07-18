using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_8137-cc4bed56")]
        public void Method_1007_8137()
        {
            ii(0x1007_8137, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_813c, 5);  call(Definitions.sys_check_available_stack_size, 0xe_dc11);/* call 0x10165d52 */
            ii(0x1007_8141, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_8142, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_8143, 1);  push(esi);                            /* push esi */
            ii(0x1007_8144, 1);  push(edi);                            /* push edi */
            ii(0x1007_8145, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_8146, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_8148, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_814e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_8151, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_8154, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1007_8159, 5);  call(0x1007_5fdc, -0x2182);           /* call 0x10075fdc */
            ii(0x1007_815e, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_8161, 2);  if(jge(0x1007_817a, 0x17)) goto l_0x1007_817a;/* jge 0x1007817a */
            ii(0x1007_8163, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1007_8168, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1007_816d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8170, 5);  call(Definitions.sys_memset, 0xe_dc6b);/* call 0x10165de0 */
            ii(0x1007_8175, 5);  jmp(0x1007_825e, 0xe4); goto l_0x1007_825e;/* jmp 0x1007825e */
        l_0x1007_817a:
            ii(0x1007_817a, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1007_817f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_8181, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8184, 5);  call(Definitions.sys_memset, 0xe_dc57);/* call 0x10165de0 */
            ii(0x1007_8189, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_818c, 4);  mov(memb[ds, eax + 4], 1);            /* mov byte [eax+0x4], 0x1 */
            ii(0x1007_8190, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_8194, 6);  imul(edx, eax, 0xc5);                 /* imul edx, eax, 0xc5 */
            ii(0x1007_819a, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1007_819f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_81a1, 5);  call(0x1008_a094, 0x1_1eee);          /* call 0x1008a094 */
            ii(0x1007_81a6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_81a9, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_81ad, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_81af, 2);  if(jl(0x1007_81bb, 0xa)) goto l_0x1007_81bb;/* jl 0x100781bb */
            ii(0x1007_81b1, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_81b5, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_81b8, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
        l_0x1007_81bb:
            ii(0x1007_81bb, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_81c2, 2);  jmp(0x1007_81ca, 6); goto l_0x1007_81ca;/* jmp 0x100781ca */
        l_0x1007_81c4:
            ii(0x1007_81c4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_81c7, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_81ca:
            ii(0x1007_81ca, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_81ce, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1007_81d1, 6);  if(jge(0x1007_825e, 0x87)) goto l_0x1007_825e;/* jge 0x1007825e */
            ii(0x1007_81d7, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_81db, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_81e1, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_81e7, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_81ec, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1007_81ef, 2);  if(jz(0x1007_820b, 0x1a)) goto l_0x1007_820b;/* jz 0x1007820b */
            ii(0x1007_81f1, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_81f5, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_81fb, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_8201, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_8206, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1007_8209, 2);  if(jnz(0x1007_8217, 0xc)) goto l_0x1007_8217;/* jnz 0x10078217 */
        l_0x1007_820b:
            ii(0x1007_820b, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_820f, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_8212, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
            ii(0x1007_8215, 2);  jmp(0x1007_8259, 0x42); goto l_0x1007_8259;/* jmp 0x10078259 */
        l_0x1007_8217:
            ii(0x1007_8217, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_821b, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_8221, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_8227, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_822c, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_822f, 2);  if(jnz(0x1007_824d, 0x1c)) goto l_0x1007_824d;/* jnz 0x1007824d */
            ii(0x1007_8231, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_8235, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1007_823b, 5);  mov(edx, 0x101c_31c4);                /* mov edx, 0x101c31c4 */
            ii(0x1007_8240, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_8242, 5);  call(0x1008_a094, 0x1_1e4d);          /* call 0x1008a094 */
            ii(0x1007_8247, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1007_824b, 2);  if(jz(0x1007_824f, 2)) goto l_0x1007_824f;/* jz 0x1007824f */
        l_0x1007_824d:
            ii(0x1007_824d, 2);  jmp(0x1007_8259, 0xa); goto l_0x1007_8259;/* jmp 0x10078259 */
        l_0x1007_824f:
            ii(0x1007_824f, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_8253, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_8256, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
        l_0x1007_8259:
            ii(0x1007_8259, 5);  jmp(0x1007_81c4, -0x9a); goto l_0x1007_81c4;/* jmp 0x100781c4 */
        l_0x1007_825e:
            ii(0x1007_825e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_8260, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_8261, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_8262, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_8263, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_8264, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_8265, 1);  ret();                                /* ret */
        }
    }
}
