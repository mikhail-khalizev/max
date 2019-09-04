using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ee97-6dfdc73")]
        public void Method_0018_ee97()
        {
            ii(0x18_ee97, 3);  mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x18_ee9a, 5);  mov(eax, memd_a32[ss, ebp + 12]);       /* mov eax, [ebp+0xc] */
            ii(0x18_ee9f, 5);  mov(ebp, memd_a32[ss, ebp + 16]);       /* mov ebp, [ebp+0x10] */
            ii(0x18_eea4, 3);  cmp(cl, 8);                             /* cmp cl, 0x8 */
            ii(0x18_eea7, 2);  if(jnz(0x18_eeb3, 0xa)) goto l_0x18_eeb3;/* jnz 0xeeb3 */
            ii(0x18_eea9, 3);  or(eax, eax);                           /* or eax, eax */
            ii(0x18_eeac, 2);  if(jz(0x18_ef0a, 0x5c)) goto l_0x18_ef0a;/* jz 0xef0a */
        l_0x18_eeae:
            ii(0x18_eeae, 2);  pop(eax);                               /* pop eax */
            ii(0x18_eeb0, 2);  pop(ebp);                               /* pop ebp */
            ii(0x18_eeb2, 1);  ret(); return;                          /* ret */
        l_0x18_eeb3:
            ii(0x18_eeb3, 2);  push(esi);                              /* push esi */
            ii(0x18_eeb5, 3);  mov(esi, eax);                          /* mov esi, eax */
            ii(0x18_eeb8, 4);  cmp(esi, 2);                            /* cmp esi, 0x2 */
            ii(0x18_eebc, 4);  if(jb(0x18_ef08, 0x48)) goto l_0x18_ef08;/* jb 0xef08 */
            ii(0x18_eec0, 3);  lar(ax, bp);                            /* lar ax, bp */
            ii(0x18_eec3, 4);  if(jnz(0x18_ef08, 0x41)) goto l_0x18_ef08;/* jnz 0xef08 */
            ii(0x18_eec7, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x18_eec9, 2);  and(al, 0x8a);                          /* and al, 0x8a */
            ii(0x18_eecb, 2);  cmp(al, -0x76 /* 0x8a */);              /* cmp al, 0x8a */
            ii(0x18_eecd, 4);  if(jnz(0x18_ef08, 0x37)) goto l_0x18_ef08;/* jnz 0xef08 */
            ii(0x18_eed1, 3);  shr(ah, 5);                             /* shr ah, 0x5 */
            ii(0x18_eed4, 3);  and(ah, 3);                             /* and ah, 0x3 */
            ii(0x18_eed7, 1);  push(bx);                               /* push bx */
            ii(0x18_eed8, 2);  mov(bx, cs);                            /* mov bx, cs */
            ii(0x18_eeda, 3);  and(bl, 3);                             /* and bl, 0x3 */
            ii(0x18_eedd, 2);  mov(al, bl);                            /* mov al, bl */
            ii(0x18_eedf, 1);  pop(bx);                                /* pop bx */
            ii(0x18_eee0, 2);  cmp(al, ah);                            /* cmp al, ah */
            ii(0x18_eee2, 4);  if(ja(0x18_ef08, 0x22)) goto l_0x18_ef08;/* ja 0xef08 */
            ii(0x18_eee6, 4);  lsl(eax, bp);                           /* lsl eax, bp */
            ii(0x18_eeea, 3);  cmp(esi, eax);                          /* cmp esi, eax */
            ii(0x18_eeed, 4);  if(ja(0x18_ef08, 0x17)) goto l_0x18_ef08;/* ja 0xef08 */
            ii(0x18_eef1, 2);  mov(ah, cl);                            /* mov ah, cl */
            ii(0x18_eef3, 3);  and(ah, 0x1f);                          /* and ah, 0x1f */
            ii(0x18_eef6, 2);  mov(al, 0xcd);                          /* mov al, 0xcd */
            ii(0x18_eef8, 1);  push(ds);                               /* push ds */
            ii(0x18_eef9, 2);  mov(ds, bp);                            /* mov ds, bp */
            ii(0x18_eefb, 4);  cmp(ax, memw_a32[ds, esi - 2]);         /* cmp ax, [esi-0x2] */
            ii(0x18_eeff, 1);  pop(ds);                                /* pop ds */
            ii(0x18_ef00, 2);  pop(esi);                               /* pop esi */
            ii(0x18_ef02, 4);  if(jnz(0x18_ef0a, 4)) goto l_0x18_ef0a; /* jnz 0xef0a */
            ii(0x18_ef06, 2);  jmp(0x18_eeae, -0x5a); goto l_0x18_eeae;/* jmp 0xeeae */
        l_0x18_ef08:
            ii(0x18_ef08, 2);  pop(esi);                               /* pop esi */
        l_0x18_ef0a:
            ii(0x18_ef0a, 2);  pop(eax);                               /* pop eax */
            ii(0x18_ef0c, 2);  pop(ebp);                               /* pop ebp */
            ii(0x18_ef0e, 3);  test(cl, 0x20);                         /* test cl, 0x20 */
            ii(0x18_ef11, 2);  if(jz(0x18_ef15, 2)) goto l_0x18_ef15;  /* jz 0xef15 */
            ii(0x18_ef13, 2);  push(eax);                              /* push eax */
        l_0x18_ef15:
            ii(0x18_ef15, 2);  pushad();                               /* pushad */
            ii(0x18_ef17, 1);  push(ds);                               /* push ds */
            ii(0x18_ef18, 2);  mov(bx, ss);                            /* mov bx, ss */
            ii(0x18_ef1a, 1);  push(es);                               /* push es */
            ii(0x18_ef1b, 4);  lar(eax, bx);                           /* lar eax, bx */
            ii(0x18_ef1f, 3);  mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x18_ef22, 5);  bt(eax, 0x16);                          /* bt eax, 0x16 */
            ii(0x18_ef27, 2);  if(jb(0x18_ef2d, 4)) goto l_0x18_ef2d;  /* jb 0xef2d */
            ii(0x18_ef29, 4);  movzx(ebp, sp);                         /* movzx ebp, sp */
        l_0x18_ef2d:
            ii(0x18_ef2d, 4);  mov(dx, memw_a32[ss, ebp + 38]);        /* mov dx, [ebp+0x26] */
            ii(0x18_ef31, 4);  and(ecx, 0x20);                         /* and ecx, 0x20 */
            ii(0x18_ef35, 2);  if(jz(0x18_ef4a, 0x13)) goto l_0x18_ef4a;/* jz 0xef4a */
            ii(0x18_ef37, 5);  xchg(memd_a32[ss, ebp + 36], eax);      /* xchg [ebp+0x24], eax */
            ii(0x18_ef3c, 5);  xchg(memd_a32[ss, ebp + 40], eax);      /* xchg [ebp+0x28], eax */
            ii(0x18_ef41, 5);  xchg(memd_a32[ss, ebp + 36], eax);      /* xchg [ebp+0x24], eax */
            ii(0x18_ef46, 4);  mov(dx, memw_a32[ss, ebp + 38]);        /* mov dx, [ebp+0x26] */
        l_0x18_ef4a:
            ii(0x18_ef4a, 4);  mov(memw_a32[ss, ebp + 28], dx);        /* mov [ebp+0x1c], dx */
            ii(0x18_ef4e, 1);  cld();                                  /* cld */
            ii(0x18_ef4f, 5);  mov(cx, memw[cs, 0x4d76]);              /* mov cx, [cs:0x4d76] */
            ii(0x18_ef54, 4);  mov(si, memw_a32[ss, ebp + 36]);        /* mov si, [ebp+0x24] */
            ii(0x18_ef58, 2);  if(jcxz(0x18_efd2, 0x78)) goto l_0x18_efd2;/* jcxz 0xefd2 */
            ii(0x18_ef5a, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x18_ef5c, 2);  push(0x20);                             /* push 0x20 */
            ii(0x18_ef5e, 1);  pop(ds);                                /* pop ds */
            ii(0x18_ef5f, 6);  add(memw[ds, 0xc16], 0x400);            /* add word [0xc16], 0x400 */
            ii(0x18_ef65, 6);  movzx(edi, memw[ds, 0xc16]);            /* movzx edi, word [0xc16] */
            ii(0x18_ef6b, 4);  cmp(di, 0x4000);                        /* cmp di, 0x4000 */
            ii(0x18_ef6f, 2);  if(ja(0x18_efcc, 0x5b)) goto l_0x18_efcc;/* ja 0xefcc */
            ii(0x18_ef71, 3);  sub(di, 0x2e);                          /* sub di, 0x2e */
            ii(0x18_ef74, 3);  lea(ax, memw[ds, si - 13]);             /* lea ax, [si-0xd] */
            ii(0x18_ef77, 4);  mov(memw[es, di + 42], ax);             /* mov [es:di+0x2a], ax */
            ii(0x18_ef7b, 4);  mov(memw[es, di + 40], ax);             /* mov [es:di+0x28], ax */
            ii(0x18_ef7f, 4);  movzx(eax, di);                         /* movzx eax, di */
            ii(0x18_ef83, 4);  xchg(memw_a32[ss, ebp + 4], ax);        /* xchg [ebp+0x4], ax */
            ii(0x18_ef87, 1);  stosw();                                /* stosw */
            ii(0x18_ef88, 1);  inc(si);                                /* inc si */
            ii(0x18_ef89, 4);  mov(memw_a32[ss, ebp + 36], si);        /* mov [ebp+0x24], si */
            ii(0x18_ef8d, 3);  add(si, -0x14 /* 0xec */);              /* add si, 0xffec */
            ii(0x18_ef90, 3);  mov(cx, 4);                             /* mov cx, 0x4 */
            ii(0x18_ef93, 3);  rep(() => movsw(cs));                   /* cs rep movsw */
            ii(0x18_ef96, 3);  mov(ax, 0x54a3);                        /* mov ax, 0x54a3 */
            ii(0x18_ef99, 2);  stosd();                                /* stosd */
            ii(0x18_ef9b, 2);  mov(ax, cs);                            /* mov ax, cs */
            ii(0x18_ef9d, 2);  stosd();                                /* stosd */
            ii(0x18_ef9f, 2);  mov(cl, 4);                             /* mov cl, 0x4 */
            ii(0x18_efa1, 5);  lea(esi, memd_a32[ss, ebp + 40]);       /* lea esi, [ebp+0x28] */
            ii(0x18_efa6, 5);  rep_a32(() => movsd_a32(ss));           /* a32 ss rep movsd */
            ii(0x18_efab, 3);  xchg(esi, eax);                         /* a32 xchg esi, eax */
            ii(0x18_efae, 2);  stosd();                                /* stosd */
            ii(0x18_efb0, 2);  mov(ax, ss);                            /* mov ax, ss */
            ii(0x18_efb2, 1);  stosw();                                /* stosw */
            ii(0x18_efb3, 1);  pop(es);                                /* pop es */
            ii(0x18_efb4, 1);  pop(ds);                                /* pop ds */
            ii(0x18_efb5, 2);  popad();                                /* popad */
            ii(0x18_efb7, 5);  mov(ss, memw[cs, 0x4d76]);              /* mov ss, [cs:0x4d76] */
            ii(0x18_efbc, 4);  movzx(esp, di);                         /* movzx esp, di */
            ii(0x18_efc0, 1);  pop(di);                                /* pop di */
            ii(0x18_efc1, 2);  retfd(); return;                        /* o32 retf */
        //  ii(0x18_efc3, 9);  Недостижимый код.
        l_0x18_efcc:
            ii(0x18_efcc, 6);  sub(memw[ds, 0xc16], 0x400);            /* sub word [0xc16], 0x400 */
        l_0x18_efd2:
            ii(0x18_efd2, 5);  add(memw_a32[ss, ebp + 36], -0xd /* 0xf3 */);/* add word [ebp+0x24], 0xfff3 */
            ii(0x18_efd7, 5);  test(memb[cs, si - 5], 0x20);           /* test byte [cs:si-0x5], 0x20 */
            ii(0x18_efdc, 1);  pop(es);                                /* pop es */
            ii(0x18_efdd, 1);  pop(ds);                                /* pop ds */
            ii(0x18_efde, 2);  popad();                                /* popad */
            ii(0x18_efe0, 2);  if(jz(0x18_efe5, 3)) goto l_0x18_efe5;  /* jz 0xefe5 */
            ii(0x18_efe2, 3);  ret(6); return;                         /* ret 0x6 */
        l_0x18_efe5:
            ii(0x18_efe5, 3);  ret(2);                                 /* ret 0x2 */
        }
    }
}
