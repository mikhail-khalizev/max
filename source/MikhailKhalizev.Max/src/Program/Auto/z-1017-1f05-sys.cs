using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1f05-8b1e1233")]
        public void /* sys */ Method_1017_1f05()
        {
            ii(0x1017_1f05, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1f06, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1f07, 1); push(edx);                              /* push edx */
            ii(0x1017_1f08, 1); push(esi);                              /* push esi */
            ii(0x1017_1f09, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_1f0b, 4); test(memb[ds, eax + 0xc], 1);           /* test byte [eax+0xc], 0x1 */
            ii(0x1017_1f0f, 2); if(jnz(0x1017_1f2b, 0x1a)) goto l_0x1017_1f2b; /* jnz 0x10171f2b */
            ii(0x1017_1f11, 5); mov(eax, 4);                            /* mov eax, 0x4 */
            ii(0x1017_1f16, 5); call(/* sys */ 0x1018_d3bf, 0x1_b4a4);  /* call 0x1018d3bf */
            ii(0x1017_1f1b, 3); mov(bl, memb[ds, edx + 0xc]);           /* mov bl, [edx+0xc] */
            ii(0x1017_1f1e, 3); or(bl, 0x20);                           /* or bl, 0x20 */
            ii(0x1017_1f21, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_1f26, 3); mov(memb[ds, edx + 0xc], bl);           /* mov [edx+0xc], bl */
            ii(0x1017_1f29, 2); jmp(0x1017_1f4b, 0x20); goto l_0x1017_1f4b; /* jmp 0x10171f4b */
        l_0x1017_1f2b:
            ii(0x1017_1f2b, 3); mov(ebx, memd[ds, edx + 4]);            /* mov ebx, [edx+0x4] */
            ii(0x1017_1f2e, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_1f2f, 3); mov(memd[ds, edx + 4], ebx);            /* mov [edx+0x4], ebx */
            ii(0x1017_1f32, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_1f34, 2); if(jge(0x1017_1f3f, 9)) goto l_0x1017_1f3f; /* jge 0x10171f3f */
            ii(0x1017_1f36, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_1f38, 5); call(/* sys */ 0x1017_1f8e, 0x51);      /* call 0x10171f8e */
            ii(0x1017_1f3d, 2); jmp(0x1017_1f4b, 0xc); goto l_0x1017_1f4b; /* jmp 0x10171f4b */
        l_0x1017_1f3f:
            ii(0x1017_1f3f, 2); mov(ebx, memd[ds, edx]);                /* mov ebx, [edx] */
            ii(0x1017_1f41, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1017_1f43, 1); inc(ebx);                               /* inc ebx */
            ii(0x1017_1f44, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_1f49, 2); mov(memd[ds, edx], ebx);                /* mov [edx], ebx */
        l_0x1017_1f4b:
            ii(0x1017_1f4b, 4); test(memb[ds, edx + 0xc], 0x40);        /* test byte [edx+0xc], 0x40 */
            ii(0x1017_1f4f, 2); if(jnz(0x1017_1f89, 0x38)) goto l_0x1017_1f89; /* jnz 0x10171f89 */
            ii(0x1017_1f51, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1017_1f54, 2); if(jnz(0x1017_1f76, 0x20)) goto l_0x1017_1f76; /* jnz 0x10171f76 */
            ii(0x1017_1f56, 3); mov(esi, memd[ds, edx + 4]);            /* mov esi, [edx+0x4] */
            ii(0x1017_1f59, 1); dec(esi);                               /* dec esi */
            ii(0x1017_1f5a, 3); mov(memd[ds, edx + 4], esi);            /* mov [edx+0x4], esi */
            ii(0x1017_1f5d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_1f5f, 2); if(jge(0x1017_1f6a, 9)) goto l_0x1017_1f6a; /* jge 0x10171f6a */
            ii(0x1017_1f61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_1f63, 5); call(/* sys */ 0x1017_1f8e, 0x26);      /* call 0x10171f8e */
            ii(0x1017_1f68, 2); jmp(0x1017_1f76, 0xc); goto l_0x1017_1f76; /* jmp 0x10171f76 */
        l_0x1017_1f6a:
            ii(0x1017_1f6a, 2); mov(ebx, memd[ds, edx]);                /* mov ebx, [edx] */
            ii(0x1017_1f6c, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1017_1f6e, 1); inc(ebx);                               /* inc ebx */
            ii(0x1017_1f6f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_1f74, 2); mov(memd[ds, edx], ebx);                /* mov [edx], ebx */
        l_0x1017_1f76:
            ii(0x1017_1f76, 3); cmp(eax, 0x1a);                         /* cmp eax, 0x1a */
            ii(0x1017_1f79, 2); if(jnz(0x1017_1f89, 0xe)) goto l_0x1017_1f89; /* jnz 0x10171f89 */
            ii(0x1017_1f7b, 3); mov(cl, memb[ds, edx + 0xc]);           /* mov cl, [edx+0xc] */
            ii(0x1017_1f7e, 3); or(cl, 0x10);                           /* or cl, 0x10 */
            ii(0x1017_1f81, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_1f86, 3); mov(memb[ds, edx + 0xc], cl);           /* mov [edx+0xc], cl */
        l_0x1017_1f89:
            ii(0x1017_1f89, 1); pop(esi);                               /* pop esi */
            ii(0x1017_1f8a, 1); pop(edx);                               /* pop edx */
            ii(0x1017_1f8b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_1f8c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_1f8d, 1); ret();                                  /* ret */
        }
    }
}
