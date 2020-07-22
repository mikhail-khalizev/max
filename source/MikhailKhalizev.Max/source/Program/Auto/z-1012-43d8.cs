using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_43d8-6b6786f6")]
        public void Method_1012_43d8()
        {
            ii(0x1012_43d8, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_43dd, 5);  call(Definitions.sys_check_available_stack_size, 0x4_1970);/* call 0x10165d52 */
            ii(0x1012_43e2, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_43e3, 1);  push(esi);                            /* push esi */
            ii(0x1012_43e4, 1);  push(edi);                            /* push edi */
            ii(0x1012_43e5, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_43e6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_43e8, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_43ee, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_43f1, 1);  push(eax);                            /* push eax */
            ii(0x1012_43f2, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_43f5, 1);  push(eax);                            /* push eax */
            ii(0x1012_43f6, 5);  call(0x1012_36fa, -0xd01);            /* call 0x101236fa */
            ii(0x1012_43fb, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_43fe, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_4400, 2);  if(jz(0x1012_440e, 0xc)) goto l_0x1012_440e;/* jz 0x1012440e */
            ii(0x1012_4402, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_4409, 5);  jmp(0x1012_44e4, 0xd6); goto l_0x1012_44e4;/* jmp 0x101244e4 */
        l_0x1012_440e:
            ii(0x1012_440e, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4411, 6);  mov(edx, memd[ds, eax + 132]);        /* mov edx, [eax+0x84] */
            ii(0x1012_4417, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_441a, 6);  mov(eax, memd[ds, eax + 136]);        /* mov eax, [eax+0x88] */
            ii(0x1012_4420, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_4422, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_4425, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4428, 5);  call(Definitions.sys_strlen, 0x4_da9a);/* call 0x10171ec7 */
            ii(0x1012_442d, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1012_4430, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_4433, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4436, 6);  mov(edx, memd[ds, eax + 136]);        /* mov edx, [eax+0x88] */
            ii(0x1012_443c, 3);  add(edx, memd[ss, ebp - 4]);          /* add edx, [ebp-0x4] */
            ii(0x1012_443f, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4442, 6);  cmp(edx, memd[ds, eax + 140]);        /* cmp edx, [eax+0x8c] */
            ii(0x1012_4448, 2);  if(jbe(0x1012_4456, 0xc)) goto l_0x1012_4456;/* jbe 0x10124456 */
            ii(0x1012_444a, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_4451, 5);  jmp(0x1012_44e4, 0x8e); goto l_0x1012_44e4;/* jmp 0x101244e4 */
        l_0x1012_4456:
            ii(0x1012_4456, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_4459, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_445c, 3);  mov(memb[ds, eax], 0xd);              /* mov byte [eax], 0xd */
            ii(0x1012_445f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_4462, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_4465, 3);  mov(memb[ds, eax], 0xa);              /* mov byte [eax], 0xa */
            ii(0x1012_4468, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_446b, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_446e, 6);  mov(memd[ds, edx + 152], eax);        /* mov [edx+0x98], eax */
            ii(0x1012_4474, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_4477, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_447a, 3);  mov(memb[ds, eax], 0x5b);             /* mov byte [eax], 0x5b */
        l_0x1012_447d:
            ii(0x1012_447d, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4480, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x1012_4483, 2);  if(jz(0x1012_4497, 0x12)) goto l_0x1012_4497;/* jz 0x10124497 */
            ii(0x1012_4485, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4488, 3);  inc(memd[ss, ebp + 24]);              /* inc dword [ebp+0x18] */
            ii(0x1012_448b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_448e, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_4491, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_4493, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1012_4495, 2);  jmp(0x1012_447d, -0x1a); goto l_0x1012_447d;/* jmp 0x1012447d */
        l_0x1012_4497:
            ii(0x1012_4497, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_449a, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_449d, 3);  mov(memb[ds, eax], 0x5d);             /* mov byte [eax], 0x5d */
            ii(0x1012_44a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_44a3, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_44a6, 3);  mov(memb[ds, eax], 0xd);              /* mov byte [eax], 0xd */
            ii(0x1012_44a9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_44ac, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_44af, 3);  mov(memb[ds, eax], 0xa);              /* mov byte [eax], 0xa */
            ii(0x1012_44b2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_44b5, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_44b8, 6);  mov(memd[ds, edx + 168], eax);        /* mov [edx+0xa8], eax */
            ii(0x1012_44be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_44c1, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_44c4, 6);  mov(memd[ds, edx + 144], eax);        /* mov [edx+0x90], eax */
            ii(0x1012_44ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_44cd, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_44d0, 6);  add(memd[ds, edx + 136], eax);        /* add [edx+0x88], eax */
            ii(0x1012_44d6, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_44d9, 4);  or(memb[ds, eax + 1], -0x80 /* 0x80 */);/* or byte [eax+0x1], 0x80 */
            ii(0x1012_44dd, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_44e4:
            ii(0x1012_44e4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_44e7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_44e9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_44ea, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_44eb, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_44ec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_44ed, 1);  ret();                                /* ret */
        }
    }
}
