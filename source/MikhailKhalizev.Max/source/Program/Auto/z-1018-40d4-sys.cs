using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_40d4-62c9d4ba")]
        public void /* sys */ Method_1018_40d4()
        {
            ii(0x1018_40d4, 1);  push(esi);                            /* push esi */
            ii(0x1018_40d5, 1);  push(edi);                            /* push edi */
            ii(0x1018_40d6, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_40d7, 3);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1018_40da, 4);  mov(memd[ss, esp + 4], eax);          /* mov [esp+0x4], eax */
            ii(0x1018_40de, 2);  mov(ebp, edx);                        /* mov ebp, edx */
            ii(0x1018_40e0, 2);  mov(esi, ebx);                        /* mov esi, ebx */
            ii(0x1018_40e2, 3);  mov(memd[ss, esp], ecx);              /* mov [esp], ecx */
            ii(0x1018_40e5, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1018_40eb, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1018_40ee, 3);  add(eax, 0x10);                       /* add eax, 0x10 */
            ii(0x1018_40f1, 4);  mov(memd[ss, esp + 8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_40f5, 4);  mov(eax, memd[ss, esp + 4]);          /* mov eax, [esp+0x4] */
            ii(0x1018_40f9, 5);  call(/* sys */ 0x1018_4ed0, 0xdd2);   /* call 0x10184ed0 */
            ii(0x1018_40fe, 4);  mov(edx, memd[ss, esp + 8]);          /* mov edx, [esp+0x8] */
            ii(0x1018_4102, 3);  lea(edi, memd[ds, eax + 4]);          /* lea edi, [eax+0x4] */
            ii(0x1018_4105, 3);  cmp(edx, 2);                          /* cmp edx, 0x2 */
            ii(0x1018_4108, 2);  if(jl(0x1018_410f, 5)) goto l_0x1018_410f;/* jl 0x1018410f */
            ii(0x1018_410a, 3);  cmp(edi, 2);                          /* cmp edi, 0x2 */
            ii(0x1018_410d, 2);  if(jge(0x1018_4119, 0xa)) goto l_0x1018_4119;/* jge 0x10184119 */
        l_0x1018_410f:
            ii(0x1018_410f, 5);  mov(esi, 0xffff_ffff);                /* mov esi, 0xffffffff */
            ii(0x1018_4114, 5);  jmp(0x1018_4199, 0x80); goto l_0x1018_4199;/* jmp 0x10184199 */
        l_0x1018_4119:
            ii(0x1018_4119, 2);  push(0x14);                           /* push 0x14 */
            ii(0x1018_411b, 4);  mov(ebx, memd[ss, esp + 36]);         /* mov ebx, [esp+0x24] */
            ii(0x1018_411f, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1018_4121, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_4123, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_4124, 4);  mov(edx, memd[ss, esp + 8]);          /* mov edx, [esp+0x8] */
            ii(0x1018_4128, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1018_412a, 5);  call(/* sys */ 0x1016_6764, -0x1_d9cb);/* call 0x10166764 */
            ii(0x1018_412f, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1018_4131, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_4134, 2);  if(jz(0x1018_4199, 0x63)) goto l_0x1018_4199;/* jz 0x10184199 */
            ii(0x1018_4136, 4);  mov(ecx, memd[ss, esp + 28]);         /* mov ecx, [esp+0x1c] */
            ii(0x1018_413a, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_413b, 2);  push(8);                              /* push 0x8 */
            ii(0x1018_413d, 4);  mov(edx, memd[ss, esp + 12]);         /* mov edx, [esp+0xc] */
            ii(0x1018_4141, 2);  push(2);                              /* push 0x2 */
            ii(0x1018_4143, 2);  mov(ebx, ebp);                        /* mov ebx, ebp */
            ii(0x1018_4145, 3);  lea(ecx, memd[ds, edi - 4]);          /* lea ecx, [edi-0x4] */
            ii(0x1018_4148, 5);  call(/* sys */ 0x1016_6f04, -0x1_d249);/* call 0x10166f04 */
            ii(0x1018_414d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_414f, 5);  mov(al, memb[ds, 0x1020_0520]);       /* mov al, [0x10200520] */
            ii(0x1018_4154, 3);  lea(ecx, memd[ds, edi - 1]);          /* lea ecx, [edi-0x1] */
            ii(0x1018_4157, 1);  push(eax);                            /* push eax */
            ii(0x1018_4158, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1018_415c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_415e, 1);  dec(eax);                             /* dec eax */
            ii(0x1018_415f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1018_4161, 1);  push(eax);                            /* push eax */
            ii(0x1018_4162, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_4164, 4);  mov(ebp, memd[ss, esp + 36]);         /* mov ebp, [esp+0x24] */
            ii(0x1018_4168, 5);  call(/* sys */ 0x1016_70b0, -0x1_d0bd);/* call 0x101670b0 */
            ii(0x1018_416d, 4);  mov(eax, memd[ss, esp + 8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_4171, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1018_4176, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_4177, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x1018_417a, 3);  lea(ecx, memd[ds, edi - 2]);          /* lea ecx, [edi-0x2] */
            ii(0x1018_417d, 1);  push(eax);                            /* push eax */
            ii(0x1018_417e, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1018_4180, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_4182, 5);  call(/* sys */ 0x1016_70b0, -0x1_d0d7);/* call 0x101670b0 */
            ii(0x1018_4187, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_4189, 4);  mov(edx, memd[ss, esp + 36]);         /* mov edx, [esp+0x24] */
            ii(0x1018_418d, 5);  call(Definitions.sys_display_draw_0, -0x1_cd0e);/* call 0x10167484 */
            ii(0x1018_4192, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_4194, 5);  call(/* sys */ 0x1016_7e74, -0x1_c325);/* call 0x10167e74 */
        l_0x1018_4199:
            ii(0x1018_4199, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_419b, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1018_419e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_419f, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_41a0, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_41a1, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
