using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bfe3-b5da40ac")]
        public void Method_100c_bfe3()
        {
            ii(0x100c_bfe3, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_bfe8, 5);  call(Definitions.sys_check_available_stack_size, 0x9_9d65);/* call 0x10165d52 */
            ii(0x100c_bfed, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_bfee, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_bfef, 1);  push(edx);                            /* push edx */
            ii(0x100c_bff0, 1);  push(esi);                            /* push esi */
            ii(0x100c_bff1, 1);  push(edi);                            /* push edi */
            ii(0x100c_bff2, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_bff3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_bff5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_bffb, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_bffe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c001, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_c004, 5);  call(0x1007_6574, -0x5_5a95);         /* call 0x10076574 */
            ii(0x100c_c009, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_c00b, 3);  mov(dl, memb[ds, eax + 77]);          /* mov dl, [eax+0x4d] */
            ii(0x100c_c00e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c011, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_c014, 5);  call(0x1007_6574, -0x5_5aa5);         /* call 0x10076574 */
            ii(0x100c_c019, 5);  call(0x1007_623c, -0x5_5de2);         /* call 0x1007623c */
            ii(0x100c_c01e, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_c021, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_c024, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_c026, 2);  if(jge(0x100c_c02e, 6)) goto l_0x100c_c02e;/* jge 0x100cc02e */
            ii(0x100c_c028, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100c_c02c, 2);  jmp(0x100c_c079, 0x4b); goto l_0x100c_c079;/* jmp 0x100cc079 */
        l_0x100c_c02e:
            ii(0x100c_c02e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c031, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_c034, 5);  call(0x1007_6574, -0x5_5ac5);         /* call 0x10076574 */
            ii(0x100c_c039, 4);  cmp(memb[ds, eax + 62], 3);           /* cmp byte [eax+0x3e], 0x3 */
            ii(0x100c_c03d, 2);  if(jnz(0x100c_c069, 0x2a)) goto l_0x100c_c069;/* jnz 0x100cc069 */
            ii(0x100c_c03f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c042, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_c045, 5);  call(0x1007_6574, -0x5_5ad6);         /* call 0x10076574 */
            ii(0x100c_c04a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_c04c, 3);  mov(dl, memb[ds, eax + 84]);          /* mov dl, [eax+0x54] */
            ii(0x100c_c04f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c052, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_c055, 5);  call(0x1007_6574, -0x5_5ae6);         /* call 0x10076574 */
            ii(0x100c_c05a, 5);  call(0x1007_623c, -0x5_5e23);         /* call 0x1007623c */
            ii(0x100c_c05f, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x100c_c062, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_c065, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_c067, 2);  if(jl(0x100c_c06f, 6)) goto l_0x100c_c06f;/* jl 0x100cc06f */
        l_0x100c_c069:
            ii(0x100c_c069, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c06d, 2);  jmp(0x100c_c073, 4); goto l_0x100c_c073;/* jmp 0x100cc073 */
        l_0x100c_c06f:
            ii(0x100c_c06f, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100c_c073:
            ii(0x100c_c073, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100c_c076, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x100c_c079:
            ii(0x100c_c079, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_c07c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_c07e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_c07f, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_c080, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_c081, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_c082, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_c083, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_c084, 1);  ret();                                /* ret */
        }
    }
}
