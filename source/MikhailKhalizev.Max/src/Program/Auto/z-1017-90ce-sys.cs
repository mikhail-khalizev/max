using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_90ce-db24561c")]
        public void /* sys */ Method_1017_90ce()
        {
            ii(0x1017_90ce, 1); push(ebx);                              /* push ebx */
            ii(0x1017_90cf, 1); push(ecx);                              /* push ecx */
            ii(0x1017_90d0, 1); push(edx);                              /* push edx */
        l_0x1017_90d1:
            ii(0x1017_90d1, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1017_90d3, 2); inc(dl);                                /* inc dl */
            ii(0x1017_90d5, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_90db, 6); mov(dl, memb[ds, edx + 0x101b_75c0]);   /* mov dl, [edx+0x101b75c0] */
            ii(0x1017_90e1, 3); and(dl, 0x2);                           /* and dl, 0x2 */
            ii(0x1017_90e4, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_90ea, 2); if(jz(0x1017_90ef, 0x3)) goto l_0x1017_90ef; /* jz 0x101790ef */
            ii(0x1017_90ec, 1); inc(eax);                               /* inc eax */
            ii(0x1017_90ed, 2); jmp(0x1017_90d1, -0x1e); goto l_0x1017_90d1; /* jmp 0x101790d1 */
        l_0x1017_90ef:
            ii(0x1017_90ef, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1017_90f1, 2); mov(dl, cl);                            /* mov dl, cl */
            ii(0x1017_90f3, 3); cmp(edx, 0x2b);                         /* cmp edx, 0x2b */
            ii(0x1017_90f6, 2); if(jz(0x1017_90fd, 0x5)) goto l_0x1017_90fd; /* jz 0x101790fd */
            ii(0x1017_90f8, 3); cmp(edx, 0x2d);                         /* cmp edx, 0x2d */
            ii(0x1017_90fb, 2); if(jnz(0x1017_90fe, 0x1)) goto l_0x1017_90fe; /* jnz 0x101790fe */
        l_0x1017_90fd:
            ii(0x1017_90fd, 1); inc(eax);                               /* inc eax */
        l_0x1017_90fe:
            ii(0x1017_90fe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1017_9100:
            ii(0x1017_9100, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1017_9102, 2); inc(dl);                                /* inc dl */
            ii(0x1017_9104, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_910a, 6); mov(dl, memb[ds, edx + 0x101b_75c0]);   /* mov dl, [edx+0x101b75c0] */
            ii(0x1017_9110, 3); and(dl, 0x20);                          /* and dl, 0x20 */
            ii(0x1017_9113, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_9119, 2); if(jz(0x1017_912a, 0xf)) goto l_0x1017_912a; /* jz 0x1017912a */
            ii(0x1017_911b, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1017_911e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_9120, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1017_9122, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1017_9124, 1); inc(eax);                               /* inc eax */
            ii(0x1017_9125, 3); sub(ebx, 0x30);                         /* sub ebx, 0x30 */
            ii(0x1017_9128, 2); jmp(0x1017_9100, -0x2a); goto l_0x1017_9100; /* jmp 0x10179100 */
        l_0x1017_912a:
            ii(0x1017_912a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_912c, 2); mov(al, cl);                            /* mov al, cl */
            ii(0x1017_912e, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1017_9131, 2); if(jnz(0x1017_9135, 0x2)) goto l_0x1017_9135; /* jnz 0x10179135 */
            ii(0x1017_9133, 2); neg(ebx);                               /* neg ebx */
        l_0x1017_9135:
            ii(0x1017_9135, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_9137, 1); pop(edx);                               /* pop edx */
            ii(0x1017_9138, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9139, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_913a, 1); ret();                                  /* ret */
        }
    }
}
