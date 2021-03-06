using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_30a2-69ae1a6a")]
        public void Method_100a_30a2()
        {
            ii(0x100a_30a2, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100a_30a7, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2ca6);/* call 0x10165d52 */
            ii(0x100a_30ac, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_30ad, 1);  push(esi);                            /* push esi */
            ii(0x100a_30ae, 1);  push(edi);                            /* push edi */
            ii(0x100a_30af, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_30b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_30b2, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100a_30b8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_30bb, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_30be, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_30c1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_30c4, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100a_30c8, 2);  if(jz(0x100a_30d3, 9)) goto l_0x100a_30d3;/* jz 0x100a30d3 */
            ii(0x100a_30ca, 7);  mov(memd[ss, ebp - 20], 2);           /* mov dword [ebp-0x14], 0x2 */
            ii(0x100a_30d1, 2);  jmp(0x100a_30da, 7); goto l_0x100a_30da;/* jmp 0x100a30da */
        l_0x100a_30d3:
            ii(0x100a_30d3, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x100a_30da:
            ii(0x100a_30da, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_30dd, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100a_30e0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_30e3, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100a_30e7, 1);  dec(eax);                             /* dec eax */
            ii(0x100a_30e8, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_30ea, 2);  if(jg(0x100a_3103, 0x17)) goto l_0x100a_3103;/* jg 0x100a3103 */
            ii(0x100a_30ec, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_30ef, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100a_30f2, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_30f5, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100a_30f9, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_30fb, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_30ff, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_3101, 2);  if(jge(0x100a_3105, 2)) goto l_0x100a_3105;/* jge 0x100a3105 */
        l_0x100a_3103:
            ii(0x100a_3103, 2);  jmp(0x100a_3117, 0x12); goto l_0x100a_3117;/* jmp 0x100a3117 */
        l_0x100a_3105:
            ii(0x100a_3105, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_3108, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100a_310b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_310e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_3112, 1);  dec(eax);                             /* dec eax */
            ii(0x100a_3113, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_3115, 2);  if(jle(0x100a_3119, 2)) goto l_0x100a_3119;/* jle 0x100a3119 */
        l_0x100a_3117:
            ii(0x100a_3117, 2);  jmp(0x100a_3130, 0x17); goto l_0x100a_3130;/* jmp 0x100a3130 */
        l_0x100a_3119:
            ii(0x100a_3119, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_311c, 3);  mov(edx, memd[ds, eax + 26]);         /* mov edx, [eax+0x1a] */
            ii(0x100a_311f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_3122, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100a_3126, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_3128, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_312c, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_312e, 2);  if(jge(0x100a_3132, 2)) goto l_0x100a_3132;/* jge 0x100a3132 */
        l_0x100a_3130:
            ii(0x100a_3130, 2);  jmp(0x100a_3138, 6); goto l_0x100a_3138;/* jmp 0x100a3138 */
        l_0x100a_3132:
            ii(0x100a_3132, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x100a_3136, 2);  jmp(0x100a_313c, 4); goto l_0x100a_313c;/* jmp 0x100a313c */
        l_0x100a_3138:
            ii(0x100a_3138, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x100a_313c:
            ii(0x100a_313c, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x100a_313f, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100a_3142, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100a_3145, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3147, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3148, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3149, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_314a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_314b, 1);  ret();                                /* ret */
        }
    }
}
