using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_11c4-9f7f14a8")]
        public void Method_100a_11c4()
        {
            ii(0x100a_11c4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_11c9, 5);  call(Definitions.sys_check_available_stack_size, 0xc_4b84);/* call 0x10165d52 */
            ii(0x100a_11ce, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_11cf, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_11d0, 1);  push(esi);                            /* push esi */
            ii(0x100a_11d1, 1);  push(edi);                            /* push edi */
            ii(0x100a_11d2, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_11d3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_11d5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_11db, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_11de, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_11e1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_11e4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_11e7, 4);  sub(memw[ds, edx + 48], ax);          /* sub [edx+0x30], ax */
            ii(0x100a_11eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_11ee, 5);  call(0x100a_04b1, -0xd42);            /* call 0x100a04b1 */
            ii(0x100a_11f3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_11f6, 3);  mov(eax, memd[ds, edx + 44]);         /* mov eax, [edx+0x2c] */
            ii(0x100a_11f9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_11fc, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_11fe, 2);  if(jge(0x100a_121a, 0x1a)) goto l_0x100a_121a;/* jge 0x100a121a */
            ii(0x100a_1200, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100a_1202, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_1205, 3);  mov(ebx, memd[ds, eax + 44]);         /* mov ebx, [eax+0x2c] */
            ii(0x100a_1208, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100a_120b, 2);  neg(ebx);                             /* neg ebx */
            ii(0x100a_120d, 5);  mov(edx, 0x20);                       /* mov edx, 0x20 */
            ii(0x100a_1212, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_1215, 5);  call(0x100a_0d25, -0x4f5);            /* call 0x100a0d25 */
        l_0x100a_121a:
            ii(0x100a_121a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_121d, 3);  mov(eax, memd[ds, eax + 44]);         /* mov eax, [eax+0x2c] */
            ii(0x100a_1220, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_1223, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_1225, 2);  if(jl(0x100a_1234, 0xd)) goto l_0x100a_1234;/* jl 0x100a1234 */
            ii(0x100a_1227, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_122a, 3);  mov(eax, memd[ds, eax + 46]);         /* mov eax, [eax+0x2e] */
            ii(0x100a_122d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_1230, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_1232, 2);  if(jge(0x100a_1236, 2)) goto l_0x100a_1236;/* jge 0x100a1236 */
        l_0x100a_1234:
            ii(0x100a_1234, 2);  jmp(0x100a_123c, 6); goto l_0x100a_123c;/* jmp 0x100a123c */
        l_0x100a_1236:
            ii(0x100a_1236, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_123a, 2);  jmp(0x100a_1252, 0x16); goto l_0x100a_1252;/* jmp 0x100a1252 */
        l_0x100a_123c:
            ii(0x100a_123c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_123f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_1242, 4);  add(memw[ds, edx + 48], ax);          /* add [edx+0x30], ax */
            ii(0x100a_1246, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_1249, 5);  call(0x100a_04b1, -0xd9d);            /* call 0x100a04b1 */
            ii(0x100a_124e, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100a_1252:
            ii(0x100a_1252, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_1255, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_1257, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_1258, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_1259, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_125a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_125b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_125c, 1);  ret();                                /* ret */
        }
    }
}
