using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_71f0-fc637bb6")]
        public void /* sys */ Method_1016_71f0()
        {
            ii(0x1016_71f0, 1); push(esi);                              /* push esi */
            ii(0x1016_71f1, 1); push(edi);                              /* push edi */
            ii(0x1016_71f2, 1); push(ebp);                              /* push ebp */
            ii(0x1016_71f3, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_71f6, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_71f8, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_71fa, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1016_71fc, 5); call(/* sys */ 0x1016_7dac, 0xbab);     /* call 0x10167dac */
            ii(0x1016_7201, 6); mov(edx, memd[ds, 0x101b_ddbc]);        /* mov edx, [0x101bddbc] */
            ii(0x1016_7207, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_720a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_720c, 6); if(jz(0x1016_72ca, 0xb8)) goto l_0x1016_72ca; /* jz 0x101672ca */
            ii(0x1016_7212, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7214, 6); if(jz(0x1016_72ca, 0xb0)) goto l_0x1016_72ca; /* jz 0x101672ca */
            ii(0x1016_721a, 4); mov(ebx, memd[ss, esp + 0x18]);         /* mov ebx, [esp+0x18] */
            ii(0x1016_721e, 6); cmp(ebx, 0x100);                        /* cmp ebx, 0x100 */
            ii(0x1016_7224, 2); if(jnz(0x1016_7270, 0x4a)) goto l_0x1016_7270; /* jnz 0x10167270 */
            ii(0x1016_7226, 7); cmp(memd[ds, 0x101c_b2e0], 0);          /* cmp dword [0x101cb2e0], 0x0 */
            ii(0x1016_722d, 2); if(jnz(0x1016_7241, 0x12)) goto l_0x1016_7241; /* jnz 0x10167241 */
            ii(0x1016_722f, 5); mov(eax, memd[ds, 0x101b_ddc0]);        /* mov eax, [0x101bddc0] */
            ii(0x1016_7234, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_723a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_723f, 2); jmp(0x1016_729b, 0x5a); goto l_0x1016_729b; /* jmp 0x1016729b */
        l_0x1016_7241:
            ii(0x1016_7241, 3); mov(ecx, memd[ds, eax + 0x28]);         /* mov ecx, [eax+0x28] */
            ii(0x1016_7244, 2); add(ecx, edi);                          /* add ecx, edi */
            ii(0x1016_7246, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7247, 3); mov(ecx, memd[ds, eax + 0x24]);         /* mov ecx, [eax+0x24] */
            ii(0x1016_724a, 2); add(ecx, ebp);                          /* add ecx, ebp */
            ii(0x1016_724c, 1); push(ecx);                              /* push ecx */
            ii(0x1016_724d, 6); mov(edx, memd[ds, 0x101c_b2e0]);        /* mov edx, [0x101cb2e0] */
            ii(0x1016_7253, 1); push(edx);                              /* push edx */
            ii(0x1016_7254, 3); mov(ecx, memd[ds, eax + 0x18]);         /* mov ecx, [eax+0x18] */
            ii(0x1016_7257, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_7259, 3); imul(edx, ecx);                         /* imul edx, ecx */
            ii(0x1016_725c, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1016_725f, 4); mov(ebx, memd[ss, esp + 0x20]);         /* mov ebx, [esp+0x20] */
            ii(0x1016_7263, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_7265, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_7267, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_7269, 5); call(/* sys */ 0x1016_addc, 0x3b6e);    /* call 0x1016addc */
            ii(0x1016_726e, 2); jmp(0x1016_729f, 0x2f); goto l_0x1016_729f; /* jmp 0x1016729f */
        l_0x1016_7270:
            ii(0x1016_7270, 5); test(memb[ss, esp + 0x19], 0xff);       /* test byte [esp+0x19], 0xff */
            ii(0x1016_7275, 2); if(jz(0x1016_7299, 0x22)) goto l_0x1016_7299; /* jz 0x10167299 */
            ii(0x1016_7277, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_7279, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_727e, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1016_7285, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_728b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_728d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_7292, 3); xor(dx, bx);                            /* xor dx, bx */
            ii(0x1016_7295, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_7297, 2); jmp(0x1016_729b, 0x2); goto l_0x1016_729b; /* jmp 0x1016729b */
        l_0x1016_7299:
            ii(0x1016_7299, 2); mov(eax, ebx);                          /* mov eax, ebx */
        l_0x1016_729b:
            ii(0x1016_729b, 4); mov(memd[ss, esp + 0x18], eax);         /* mov [esp+0x18], eax */
        l_0x1016_729f:
            ii(0x1016_729f, 4); mov(ebx, memd[ss, esp + 0x18]);         /* mov ebx, [esp+0x18] */
            ii(0x1016_72a3, 6); cmp(ebx, 0x100);                        /* cmp ebx, 0x100 */
            ii(0x1016_72a9, 2); if(jge(0x1016_72ca, 0x1f)) goto l_0x1016_72ca; /* jge 0x101672ca */
            ii(0x1016_72ab, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1016_72ae, 3); mov(ecx, memd[ds, ecx + 0x18]);         /* mov ecx, [ecx+0x18] */
            ii(0x1016_72b1, 3); imul(edi, ecx);                         /* imul edi, ecx */
            ii(0x1016_72b4, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_72b7, 1); push(ebx);                              /* push ebx */
            ii(0x1016_72b8, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1016_72bb, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_72bd, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_72bf, 4); mov(ebx, memd[ss, esp + 0x18]);         /* mov ebx, [esp+0x18] */
            ii(0x1016_72c3, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_72c5, 5); call(/* sys */ 0x1016_ad78, 0x3aae);    /* call 0x1016ad78 */
        l_0x1016_72ca:
            ii(0x1016_72ca, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_72cd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_72ce, 1); pop(edi);                               /* pop edi */
            ii(0x1016_72cf, 1); pop(esi);                               /* pop esi */
            ii(0x1016_72d0, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
