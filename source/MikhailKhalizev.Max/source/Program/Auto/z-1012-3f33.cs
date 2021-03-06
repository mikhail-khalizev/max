using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3f33-dc110abb")]
        public void Method_1012_3f33()
        {
            ii(0x1012_3f33, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1012_3f38, 5);  call(Definitions.sys_check_available_stack_size, 0x4_1e15);/* call 0x10165d52 */
            ii(0x1012_3f3d, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_3f3e, 1);  push(esi);                            /* push esi */
            ii(0x1012_3f3f, 1);  push(edi);                            /* push edi */
            ii(0x1012_3f40, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_3f41, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_3f43, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1012_3f49, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3f4c, 6);  mov(eax, memd[ds, eax + 160]);        /* mov eax, [eax+0xa0] */
            ii(0x1012_3f52, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_3f55, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1012_3f59, 2);  if(jnz(0x1012_3f67, 0xc)) goto l_0x1012_3f67;/* jnz 0x10123f67 */
            ii(0x1012_3f5b, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_3f62, 5);  jmp(0x1012_408c, 0x125); goto l_0x1012_408c;/* jmp 0x1012408c */
        l_0x1012_3f67:
            ii(0x1012_3f67, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1012_3f6e:
            ii(0x1012_3f6e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3f71, 3);  cmp(memb[ds, eax], 0x20);             /* cmp byte [eax], 0x20 */
            ii(0x1012_3f74, 2);  if(jnz(0x1012_3f7e, 8)) goto l_0x1012_3f7e;/* jnz 0x10123f7e */
            ii(0x1012_3f76, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3f79, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x1012_3f7c, 2);  jmp(0x1012_3f6e, -0x10); goto l_0x1012_3f6e;/* jmp 0x10123f6e */
        l_0x1012_3f7e:
            ii(0x1012_3f7e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3f81, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1012_3f84:
            ii(0x1012_3f84, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3f87, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x1012_3f8a, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_3f8c, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_3f91, 3);  cmp(eax, 0xd);                        /* cmp eax, 0xd */
            ii(0x1012_3f94, 2);  if(jz(0x1012_3f9e, 8)) goto l_0x1012_3f9e;/* jz 0x10123f9e */
            ii(0x1012_3f96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_3f99, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
            ii(0x1012_3f9c, 2);  jmp(0x1012_3f84, -0x1a); goto l_0x1012_3f84;/* jmp 0x10123f84 */
        l_0x1012_3f9e:
            ii(0x1012_3f9e, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3fa1, 5);  call(Definitions.sys_strlen, 0x4_df21);/* call 0x10171ec7 */
            ii(0x1012_3fa6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_3fa9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3fac, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_3faf, 2);  if(jae(0x1012_3ff6, 0x45)) goto l_0x1012_3ff6;/* jae 0x10123ff6 */
            ii(0x1012_3fb1, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3fb4, 6);  mov(edx, memd[ds, eax + 132]);        /* mov edx, [eax+0x84] */
            ii(0x1012_3fba, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3fbd, 6);  add(edx, memd[ds, eax + 136]);        /* add edx, [eax+0x88] */
            ii(0x1012_3fc3, 3);  sub(edx, memd[ss, ebp - 16]);         /* sub edx, [ebp-0x10] */
            ii(0x1012_3fc6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_3fc9, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1012_3fcc, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1012_3fce, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_3fd1, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1012_3fd4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_3fd7, 3);  sub(edx, memd[ss, ebp - 8]);          /* sub edx, [ebp-0x8] */
            ii(0x1012_3fda, 3);  add(edx, memd[ss, ebp - 16]);         /* add edx, [ebp-0x10] */
            ii(0x1012_3fdd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_3fe0, 5);  call(/* sys */ 0x1016_6177, 0x4_2192);/* call 0x10166177 */
            ii(0x1012_3fe5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_3fe8, 3);  sub(edx, memd[ss, ebp - 8]);          /* sub edx, [ebp-0x8] */
            ii(0x1012_3feb, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3fee, 6);  sub(memd[ds, eax + 136], edx);        /* sub [eax+0x88], edx */
            ii(0x1012_3ff4, 2);  jmp(0x1012_4064, 0x6e); goto l_0x1012_4064;/* jmp 0x10124064 */
        l_0x1012_3ff6:
            ii(0x1012_3ff6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3ff9, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_3ffc, 2);  if(jbe(0x1012_4064, 0x66)) goto l_0x1012_4064;/* jbe 0x10124064 */
            ii(0x1012_3ffe, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_4001, 3);  sub(edx, memd[ss, ebp - 4]);          /* sub edx, [ebp-0x4] */
            ii(0x1012_4004, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4007, 6);  add(edx, memd[ds, eax + 136]);        /* add edx, [eax+0x88] */
            ii(0x1012_400d, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4010, 6);  cmp(edx, memd[ds, eax + 140]);        /* cmp edx, [eax+0x8c] */
            ii(0x1012_4016, 2);  if(jbe(0x1012_4021, 9)) goto l_0x1012_4021;/* jbe 0x10124021 */
            ii(0x1012_4018, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_401f, 2);  jmp(0x1012_408c, 0x6b); goto l_0x1012_408c;/* jmp 0x1012408c */
        l_0x1012_4021:
            ii(0x1012_4021, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4024, 6);  mov(edx, memd[ds, eax + 132]);        /* mov edx, [eax+0x84] */
            ii(0x1012_402a, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_402d, 6);  add(edx, memd[ds, eax + 136]);        /* add edx, [eax+0x88] */
            ii(0x1012_4033, 3);  sub(edx, memd[ss, ebp - 16]);         /* sub edx, [ebp-0x10] */
            ii(0x1012_4036, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_4039, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1012_403c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_403e, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_4041, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1012_4044, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_4047, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_404a, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1012_404d, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1012_4050, 5);  call(/* sys */ 0x1016_6177, 0x4_2122);/* call 0x10166177 */
            ii(0x1012_4055, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_4058, 3);  sub(edx, memd[ss, ebp - 4]);          /* sub edx, [ebp-0x4] */
            ii(0x1012_405b, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_405e, 6);  add(memd[ds, eax + 136], edx);        /* add [eax+0x88], edx */
        l_0x1012_4064:
            ii(0x1012_4064, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4067, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x1012_406a, 2);  if(jz(0x1012_407e, 0x12)) goto l_0x1012_407e;/* jz 0x1012407e */
            ii(0x1012_406c, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_406f, 3);  inc(memd[ss, ebp + 24]);              /* inc dword [ebp+0x18] */
            ii(0x1012_4072, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_4075, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4078, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_407a, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1012_407c, 2);  jmp(0x1012_4064, -0x1a); goto l_0x1012_4064;/* jmp 0x10124064 */
        l_0x1012_407e:
            ii(0x1012_407e, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4081, 4);  or(memb[ds, eax + 1], -0x80 /* 0x80 */);/* or byte [eax+0x1], 0x80 */
            ii(0x1012_4085, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
        l_0x1012_408c:
            ii(0x1012_408c, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_408f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_4091, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_4092, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_4093, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_4094, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_4095, 1);  ret();                                /* ret */
        }
    }
}
