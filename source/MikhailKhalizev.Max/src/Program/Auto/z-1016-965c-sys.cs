using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_965c-542bd973")]
        public void /* sys */ Method_1016_965c()
        {
            ii(0x1016_965c, 1); push(ebx);                              /* push ebx */
            ii(0x1016_965d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_965e, 1); push(edx);                              /* push edx */
            ii(0x1016_965f, 1); push(esi);                              /* push esi */
            ii(0x1016_9660, 1); push(edi);                              /* push edi */
            ii(0x1016_9661, 1); push(ebp);                              /* push ebp */
            ii(0x1016_9662, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_9665, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_966c, 2); if(jnz(0x1016_9678, 0xa)) goto l_0x1016_9678; /* jnz 0x10169678 */
            ii(0x1016_966e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9673, 5); jmp(0x1016_9709, 0x91); goto l_0x1016_9709; /* jmp 0x10169709 */
        l_0x1016_9678:
            ii(0x1016_9678, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_967a, 5); call(/* sys */ 0x1016_7f00, -0x177f);   /* call 0x10167f00 */
            ii(0x1016_967f, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_9681, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9683, 2); if(jnz(0x1016_9694, 0xf)) goto l_0x1016_9694; /* jnz 0x10169694 */
            ii(0x1016_9685, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_968a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_968d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_968e, 1); pop(edi);                               /* pop edi */
            ii(0x1016_968f, 1); pop(esi);                               /* pop esi */
            ii(0x1016_9690, 1); pop(edx);                               /* pop edx */
            ii(0x1016_9691, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_9692, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_9693, 1); ret(); return;                          /* ret */
        l_0x1016_9694:
            ii(0x1016_9694, 3); mov(ebx, memd[ds, eax + 0x6c]);         /* mov ebx, [eax+0x6c] */
            ii(0x1016_9697, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_9699, 2); if(jnz(0x1016_96a6, 0xb)) goto l_0x1016_96a6; /* jnz 0x101696a6 */
            ii(0x1016_969b, 3); mov(edx, memd[ds, eax + 0x70]);         /* mov edx, [eax+0x70] */
            ii(0x1016_969e, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_96a1, 3); mov(memd[ds, eax + 0x30], edx);         /* mov [eax+0x30], edx */
            ii(0x1016_96a4, 2); jmp(0x1016_96ac, 0x6); goto l_0x1016_96ac; /* jmp 0x101696ac */
        l_0x1016_96a6:
            ii(0x1016_96a6, 3); mov(eax, memd[ds, eax + 0x70]);         /* mov eax, [eax+0x70] */
            ii(0x1016_96a9, 3); mov(memd[ds, ebx + 0x70], eax);         /* mov [ebx+0x70], eax */
        l_0x1016_96ac:
            ii(0x1016_96ac, 3); mov(ecx, memd[ds, esi + 0x70]);         /* mov ecx, [esi+0x70] */
            ii(0x1016_96af, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_96b1, 2); if(jz(0x1016_96b9, 0x6)) goto l_0x1016_96b9; /* jz 0x101696b9 */
            ii(0x1016_96b3, 3); mov(eax, memd[ds, esi + 0x6c]);         /* mov eax, [esi+0x6c] */
            ii(0x1016_96b6, 3); mov(memd[ds, ecx + 0x6c], eax);         /* mov [ecx+0x6c], eax */
        l_0x1016_96b9:
            ii(0x1016_96b9, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_96bc, 3); mov(ebp, memd[ds, esi + 0xc]);          /* mov ebp, [esi+0xc] */
            ii(0x1016_96bf, 3); mov(edi, memd[ds, eax + 0x20]);         /* mov edi, [eax+0x20] */
            ii(0x1016_96c2, 3); mov(eax, memd[ds, esi + 0x14]);         /* mov eax, [esi+0x14] */
            ii(0x1016_96c5, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1016_96c7, 1); push(edi);                              /* push edi */
            ii(0x1016_96c8, 1); inc(eax);                               /* inc eax */
            ii(0x1016_96c9, 3); mov(edx, memd[ds, esi + 0x8]);          /* mov edx, [esi+0x8] */
            ii(0x1016_96cc, 1); push(eax);                              /* push eax */
            ii(0x1016_96cd, 3); mov(eax, memd[ds, esi + 0x10]);         /* mov eax, [esi+0x10] */
            ii(0x1016_96d0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_96d2, 3); lea(ecx, eax + 0x1);                    /* lea ecx, [eax+0x1] */
            ii(0x1016_96d5, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1016_96d9, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
            ii(0x1016_96db, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1016_96dd, 5); call(/* sys */ 0x1016_71f0, -0x24f2);   /* call 0x101671f0 */
            ii(0x1016_96e2, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_96e5, 3); cmp(esi, memd[ds, eax + 0x34]);         /* cmp esi, [eax+0x34] */
            ii(0x1016_96e8, 2); if(jnz(0x1016_96f1, 0x7)) goto l_0x1016_96f1; /* jnz 0x101696f1 */
            ii(0x1016_96ea, 7); mov(memd[ds, eax + 0x34], 0);           /* mov dword [eax+0x34], 0x0 */
        l_0x1016_96f1:
            ii(0x1016_96f1, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_96f4, 3); cmp(esi, memd[ds, eax + 0x38]);         /* cmp esi, [eax+0x38] */
            ii(0x1016_96f7, 2); if(jnz(0x1016_9700, 0x7)) goto l_0x1016_9700; /* jnz 0x10169700 */
            ii(0x1016_96f9, 7); mov(memd[ds, eax + 0x38], 0);           /* mov dword [eax+0x38], 0x0 */
        l_0x1016_9700:
            ii(0x1016_9700, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9702, 5); call(/* sys */ 0x1016_9714, 0xd);       /* call 0x10169714 */
            ii(0x1016_9707, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_9709:
            ii(0x1016_9709, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_970c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_970d, 1); pop(edi);                               /* pop edi */
            ii(0x1016_970e, 1); pop(esi);                               /* pop esi */
            ii(0x1016_970f, 1); pop(edx);                               /* pop edx */
            ii(0x1016_9710, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_9711, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_9712, 1); ret();                                  /* ret */
        }
    }
}
