using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9b80-91f27ae7")]
        public void /* sys */ Method_1017_9b80()
        {
            ii(0x1017_9b80, 1); inc(ebp);                               /* inc ebp */
            ii(0x1017_9b81, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9b82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9b84, 1); push(esi);                              /* push esi */
            ii(0x1017_9b85, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1017_9b88, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_9b8a, 6); if(jnz(0x1017_9c26, 0x96)) goto l_0x1017_9c26; /* jnz 0x10179c26 */
            ii(0x1017_9b90, 7); cmp(memd[ds, 0x101b_e438], 0);          /* cmp dword [0x101be438], 0x0 */
            ii(0x1017_9b97, 6); if(jnz(0x1017_9c15, 0x78)) goto l_0x1017_9c15; /* jnz 0x10179c15 */
            ii(0x1017_9b9d, 7); cmp(memd[ds, 0x1020_9d98], 0);          /* cmp dword [0x10209d98], 0x0 */
            ii(0x1017_9ba4, 2); if(jbe(0x1017_9c15, 0x6f)) goto l_0x1017_9c15; /* jbe 0x10179c15 */
            ii(0x1017_9ba6, 7); cmp(memd[ds, 0x101b_e434], -1 /* 0xff */); /* cmp dword [0x101be434], 0xffffffff */
            ii(0x1017_9bad, 2); if(jz(0x1017_9c15, 0x66)) goto l_0x1017_9c15; /* jz 0x10179c15 */
            ii(0x1017_9baf, 5); mov(eax, memd[ds, 0x1020_9d1c]);        /* mov eax, [0x10209d1c] */
            ii(0x1017_9bb4, 7); mov(eax, memd[ds, eax * 8 + 0x1020_9a70]); /* mov eax, [eax*8+0x10209a70] */
            ii(0x1017_9bbb, 6); mov(memw[ds, 0x1020_9d28], ds);         /* mov [0x10209d28], ds */
            ii(0x1017_9bc1, 5); mov(memd[ds, 0x1020_9d24], eax);        /* mov [0x10209d24], eax */
            ii(0x1017_9bc6, 5); mov(eax, memd[ds, 0x1020_9d1c]);        /* mov eax, [0x10209d1c] */
            ii(0x1017_9bcb, 7); mov(eax, memd[ds, eax * 8 + 0x1020_9a74]); /* mov eax, [eax*8+0x10209a74] */
            ii(0x1017_9bd2, 5); mov(memd[ds, 0x1020_9d2c], eax);        /* mov [0x10209d2c], eax */
            ii(0x1017_9bd7, 6); add(memd[ds, 0x1020_9da8], eax);        /* add [0x10209da8], eax */
            ii(0x1017_9bdd, 7); cmp(memd[ds, 0x1020_9d1c], 0x3b);       /* cmp dword [0x10209d1c], 0x3b */
            ii(0x1017_9be4, 2); if(jnz(0x1017_9bf0, 0xa)) goto l_0x1017_9bf0; /* jnz 0x10179bf0 */
            ii(0x1017_9be6, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_9be8, 6); mov(memd[ds, 0x1020_9d1c], esi);        /* mov [0x10209d1c], esi */
            ii(0x1017_9bee, 2); jmp(0x1017_9bf6, 6); goto l_0x1017_9bf6; /* jmp 0x10179bf6 */
        l_0x1017_9bf0:
            ii(0x1017_9bf0, 6); inc(memd[ds, 0x1020_9d1c]);             /* inc dword [0x10209d1c] */
        l_0x1017_9bf6:
            ii(0x1017_9bf6, 6); mov(edx, memd[ds, 0x101b_e434]);        /* mov edx, [0x101be434] */
            ii(0x1017_9bfc, 5); mov(ebx, 0x1020_9d24);                  /* mov ebx, 0x10209d24 */
            ii(0x1017_9c01, 5); mov(eax, memd[ds, 0x101b_e418]);        /* mov eax, [0x101be418] */
            ii(0x1017_9c06, 2); mov(ecx, ds);                           /* mov ecx, ds */
            ii(0x1017_9c08, 5); call(/* sys */ 0x1018_03dc, 0x67cf);    /* call 0x101803dc */
            ii(0x1017_9c0d, 6); dec(memd[ds, 0x1020_9d98]);             /* dec dword [0x10209d98] */
            ii(0x1017_9c13, 2); jmp(0x1017_9c35, 0x20); goto l_0x1017_9c35; /* jmp 0x10179c35 */
        l_0x1017_9c15:
            ii(0x1017_9c15, 10); mov(memd[ds, 0x101b_e434], 0xffff_ffff); /* mov dword [0x101be434], 0xffffffff */
            ii(0x1017_9c1f, 3); lea(esp, memd[ss, ebp - 4]);            /* lea esp, [ebp-0x4] */
            ii(0x1017_9c22, 1); pop(esi);                               /* pop esi */
            ii(0x1017_9c23, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9c24, 1); dec(ebp);                               /* dec ebp */
            ii(0x1017_9c25, 1); retf(); return;                         /* retf */
        l_0x1017_9c26:
            ii(0x1017_9c26, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1017_9c29, 2); if(jnz(0x1017_9c35, 0xa)) goto l_0x1017_9c35; /* jnz 0x10179c35 */
            ii(0x1017_9c2b, 10); mov(memd[ds, 0x1020_9d9c], 1);         /* mov dword [0x10209d9c], 0x1 */
        l_0x1017_9c35:
            ii(0x1017_9c35, 3); lea(esp, memd[ss, ebp - 4]);            /* lea esp, [ebp-0x4] */
            ii(0x1017_9c38, 1); pop(esi);                               /* pop esi */
            ii(0x1017_9c39, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9c3a, 1); dec(ebp);                               /* dec ebp */
            ii(0x1017_9c3b, 1); retf();                                 /* retf */
        }
    }
}
