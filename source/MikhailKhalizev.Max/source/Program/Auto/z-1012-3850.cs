using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3850-81dcc4f2")]
        public void Method_1012_3850()
        {
            ii(0x1012_3850, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1012_3855, 5);  call(Definitions.sys_check_available_stack_size, 0x4_24f8);/* call 0x10165d52 */
            ii(0x1012_385a, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_385b, 1);  push(esi);                            /* push esi */
            ii(0x1012_385c, 1);  push(edi);                            /* push edi */
            ii(0x1012_385d, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_385e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_3860, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1012_3866, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_386d, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3870, 6);  mov(eax, memd[ds, eax + 144]);        /* mov eax, [eax+0x90] */
            ii(0x1012_3876, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_3879, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_387c, 6);  mov(eax, memd[ds, eax + 148]);        /* mov eax, [eax+0x94] */
            ii(0x1012_3882, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_3885, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3888, 6);  mov(edx, memd[ds, eax + 132]);        /* mov edx, [eax+0x84] */
            ii(0x1012_388e, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3891, 6);  mov(eax, memd[ds, eax + 136]);        /* mov eax, [eax+0x88] */
            ii(0x1012_3897, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_3899, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1012_389c:
            ii(0x1012_389c, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_389f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_38a2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38a5, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1012_38a7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_38aa, 2);  cmp(dl, memb[ds, eax]);               /* cmp dl, [eax] */
            ii(0x1012_38ac, 6);  if(jnz(0x1012_3990, 0xde)) goto l_0x1012_3990;/* jnz 0x10123990 */
            ii(0x1012_38b2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38b5, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_38b8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38bb, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1012_38be, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_38c1, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x1012_38c4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_38c7, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1012_38ca:
            ii(0x1012_38ca, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38cd, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1012_38cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_38d2, 2);  cmp(dl, memb[ds, eax]);               /* cmp dl, [eax] */
            ii(0x1012_38d4, 2);  if(jnz(0x1012_38de, 8)) goto l_0x1012_38de;/* jnz 0x101238de */
            ii(0x1012_38d6, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38d9, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_38dc, 2);  if(jb(0x1012_38e0, 2)) goto l_0x1012_38e0;/* jb 0x101238e0 */
        l_0x1012_38de:
            ii(0x1012_38de, 2);  jmp(0x1012_38f4, 0x14); goto l_0x1012_38f4;/* jmp 0x101238f4 */
        l_0x1012_38e0:
            ii(0x1012_38e0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_38e3, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1012_38e6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_38e9, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x1012_38ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_38ef, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_38f2, 2);  jmp(0x1012_38ca, -0x2a); goto l_0x1012_38ca;/* jmp 0x101238ca */
        l_0x1012_38f4:
            ii(0x1012_38f4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_38f7, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_38f9, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_38fe, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_3900, 6);  if(jnz(0x1012_3990, 0x8a)) goto l_0x1012_3990;/* jnz 0x10123990 */
        l_0x1012_3906:
            ii(0x1012_3906, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3909, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_390c, 2);  if(jae(0x1012_3916, 8)) goto l_0x1012_3916;/* jae 0x10123916 */
            ii(0x1012_390e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3911, 3);  cmp(memb[ds, eax], 0x3d);             /* cmp byte [eax], 0x3d */
            ii(0x1012_3914, 2);  if(jnz(0x1012_3918, 2)) goto l_0x1012_3918;/* jnz 0x10123918 */
        l_0x1012_3916:
            ii(0x1012_3916, 2);  jmp(0x1012_3927, 0xf); goto l_0x1012_3927;/* jmp 0x10123927 */
        l_0x1012_3918:
            ii(0x1012_3918, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_391b, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_391d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_3922, 3);  cmp(eax, 0xd);                        /* cmp eax, 0xd */
            ii(0x1012_3925, 2);  if(jnz(0x1012_3929, 2)) goto l_0x1012_3929;/* jnz 0x10123929 */
        l_0x1012_3927:
            ii(0x1012_3927, 2);  jmp(0x1012_3937, 0xe); goto l_0x1012_3937;/* jmp 0x10123937 */
        l_0x1012_3929:
            ii(0x1012_3929, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_392c, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1012_392f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3932, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3935, 2);  jmp(0x1012_3906, -0x31); goto l_0x1012_3906;/* jmp 0x10123906 */
        l_0x1012_3937:
            ii(0x1012_3937, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_393a, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_393d, 2);  if(jae(0x1012_3947, 8)) goto l_0x1012_3947;/* jae 0x10123947 */
            ii(0x1012_393f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3942, 3);  cmp(memb[ds, eax], 0x3d);             /* cmp byte [eax], 0x3d */
            ii(0x1012_3945, 2);  if(jz(0x1012_3949, 2)) goto l_0x1012_3949;/* jz 0x10123949 */
        l_0x1012_3947:
            ii(0x1012_3947, 2);  jmp(0x1012_3963, 0x1a); goto l_0x1012_3963;/* jmp 0x10123963 */
        l_0x1012_3949:
            ii(0x1012_3949, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_394c, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1012_394f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3952, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3955, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3958, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_395b, 6);  mov(memd[ds, edx + 160], eax);        /* mov [edx+0xa0], eax */
            ii(0x1012_3961, 2);  jmp(0x1012_3970, 0xd); goto l_0x1012_3970;/* jmp 0x10123970 */
        l_0x1012_3963:
            ii(0x1012_3963, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3966, 10);  mov(memd[ds, eax + 160], 0);         /* mov dword [eax+0xa0], 0x0 */
        l_0x1012_3970:
            ii(0x1012_3970, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3973, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_3976, 6);  mov(memd[ds, edx + 156], eax);        /* mov [edx+0x9c], eax */
            ii(0x1012_397c, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_397f, 10);  mov(memd[ds, eax + 164], 0);         /* mov dword [eax+0xa4], 0x0 */
            ii(0x1012_3989, 7);  mov(memd[ss, ebp - 4], 1);            /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_3990:
            ii(0x1012_3990, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_3994, 2);  if(jnz(0x1012_39bd, 0x27)) goto l_0x1012_39bd;/* jnz 0x101239bd */
        l_0x1012_3996:
            ii(0x1012_3996, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3999, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_399c, 2);  if(jae(0x1012_39ad, 0xf)) goto l_0x1012_39ad;/* jae 0x101239ad */
            ii(0x1012_399e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39a1, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_39a3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_39a8, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1012_39ab, 2);  if(jnz(0x1012_39af, 2)) goto l_0x1012_39af;/* jnz 0x101239af */
        l_0x1012_39ad:
            ii(0x1012_39ad, 2);  jmp(0x1012_39bd, 0xe); goto l_0x1012_39bd;/* jmp 0x101239bd */
        l_0x1012_39af:
            ii(0x1012_39af, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39b2, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1012_39b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_39b8, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_39bb, 2);  jmp(0x1012_3996, -0x27); goto l_0x1012_3996;/* jmp 0x10123996 */
        l_0x1012_39bd:
            ii(0x1012_39bd, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39c0, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_39c3, 2);  if(jae(0x1012_39cb, 6)) goto l_0x1012_39cb;/* jae 0x101239cb */
            ii(0x1012_39c5, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39c8, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x1012_39cb:
            ii(0x1012_39cb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_39ce, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_39d1, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_39d5, 2);  if(jnz(0x1012_39df, 8)) goto l_0x1012_39df;/* jnz 0x101239df */
            ii(0x1012_39d7, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39da, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1012_39dd, 2);  if(jb(0x1012_39e1, 2)) goto l_0x1012_39e1;/* jb 0x101239e1 */
        l_0x1012_39df:
            ii(0x1012_39df, 2);  jmp(0x1012_39e9, 8); goto l_0x1012_39e9;/* jmp 0x101239e9 */
        l_0x1012_39e1:
            ii(0x1012_39e1, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_39e4, 3);  cmp(memb[ds, eax], 0x5b);             /* cmp byte [eax], 0x5b */
            ii(0x1012_39e7, 2);  if(jnz(0x1012_39eb, 2)) goto l_0x1012_39eb;/* jnz 0x101239eb */
        l_0x1012_39e9:
            ii(0x1012_39e9, 2);  jmp(0x1012_39f0, 5); goto l_0x1012_39f0;/* jmp 0x101239f0 */
        l_0x1012_39eb:
            ii(0x1012_39eb, 5);  jmp(0x1012_389c, -0x154); goto l_0x1012_389c;/* jmp 0x1012389c */
        l_0x1012_39f0:
            ii(0x1012_39f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_39f3, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_39f6, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_39f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_39fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_39fc, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_39fd, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_39fe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_39ff, 1);  ret();                                /* ret */
        }
    }
}
