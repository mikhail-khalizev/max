using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9ad0-d05916e7")]
        public void /* sys */ Method_1016_9ad0()
        {
            ii(0x1016_9ad0, 1); push(ebx);                              /* push ebx */
            ii(0x1016_9ad1, 1); push(ecx);                              /* push ecx */
            ii(0x1016_9ad2, 1); push(edx);                              /* push edx */
            ii(0x1016_9ad3, 1); push(esi);                              /* push esi */
            ii(0x1016_9ad4, 1); push(edi);                              /* push edi */
            ii(0x1016_9ad5, 1); push(ebp);                              /* push ebp */
            ii(0x1016_9ad6, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_9ad9, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1016_9add, 4); cmp(memd[ds, eax + 0x68], 0);           /* cmp dword [eax+0x68], 0x0 */
            ii(0x1016_9ae1, 6); if(jz(0x1016_9b84, 0x9d)) goto l_0x1016_9b84; /* jz 0x10169b84 */
            ii(0x1016_9ae7, 4); test(memb[ds, eax + 0x6], 0x4);         /* test byte [eax+0x6], 0x4 */
            ii(0x1016_9aeb, 2); if(jz(0x1016_9b52, 0x65)) goto l_0x1016_9b52; /* jz 0x10169b52 */
            ii(0x1016_9aed, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_9af0, 4); cmp(memd[ds, eax + 0x4], 0);            /* cmp dword [eax+0x4], 0x0 */
            ii(0x1016_9af4, 6); if(jle(0x1016_9b74, 0x7a)) goto l_0x1016_9b74; /* jle 0x10169b74 */
            ii(0x1016_9afa, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1016_9afc, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_9afe, 2); jmp(0x1016_9b44, 0x44); goto l_0x1016_9b44; /* jmp 0x10169b44 */
        l_0x1016_9b00:
            ii(0x1016_9b00, 4); mov(esi, memd[ds, eax + ebp + 0x10]);   /* mov esi, [eax+ebp+0x10] */
            ii(0x1016_9b04, 3); mov(dh, memb[ds, esi + 0x6]);           /* mov dh, [esi+0x6] */
            ii(0x1016_9b07, 3); test(dh, 0x2);                          /* test dh, 0x2 */
            ii(0x1016_9b0a, 2); if(jz(0x1016_9b40, 0x34)) goto l_0x1016_9b40; /* jz 0x10169b40 */
            ii(0x1016_9b0c, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9b11, 2); mov(bl, dh);                            /* mov bl, dh */
            ii(0x1016_9b13, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_9b15, 3); and(bl, 0xfd);                          /* and bl, 0xfd */
            ii(0x1016_9b18, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_9b1a, 3); mov(memb[ds, esi + 0x6], bl);           /* mov [esi+0x6], bl */
            ii(0x1016_9b1d, 5); call(/* sys */ 0x1016_7f00, -0x1c22);   /* call 0x10167f00 */
            ii(0x1016_9b22, 2); push(0);                                /* push 0x0 */
            ii(0x1016_9b24, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1016_9b28, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9b2a, 3); mov(ebx, memd[ds, esi + 0x30]);         /* mov ebx, [esi+0x30] */
            ii(0x1016_9b2d, 5); call(/* sys */ 0x1016_9b90, 0x5e);      /* call 0x10169b90 */
            ii(0x1016_9b32, 4); cmp(memd[ds, esi + 0x5c], 0);           /* cmp dword [esi+0x5c], 0x0 */
            ii(0x1016_9b36, 2); if(jz(0x1016_9b40, 0x8)) goto l_0x1016_9b40; /* jz 0x10169b40 */
            ii(0x1016_9b38, 3); mov(edx, memd[ds, esi + 0x24]);         /* mov edx, [esi+0x24] */
            ii(0x1016_9b3b, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_9b3d, 3); call_abs(memd[ds, esi + 0x5c]);         /* call dword [esi+0x5c] */
        l_0x1016_9b40:
            ii(0x1016_9b40, 3); add(ebp, 0x4);                          /* add ebp, 0x4 */
            ii(0x1016_9b43, 1); inc(edi);                               /* inc edi */
        l_0x1016_9b44:
            ii(0x1016_9b44, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_9b48, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_9b4b, 3); cmp(edi, memd[ds, eax + 0xc]);          /* cmp edi, [eax+0xc] */
            ii(0x1016_9b4e, 2); if(jge(0x1016_9b74, 0x24)) goto l_0x1016_9b74; /* jge 0x10169b74 */
            ii(0x1016_9b50, 2); jmp(0x1016_9b00, -0x52); goto l_0x1016_9b00; /* jmp 0x10169b00 */
        l_0x1016_9b52:
            ii(0x1016_9b52, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_9b55, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x1016_9b58, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1016_9b5a, 2); if(jl(0x1016_9b74, 0x18)) goto l_0x1016_9b74; /* jl 0x10169b74 */
            ii(0x1016_9b5c, 4); cmp(memd[ds, eax + 0x8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x1016_9b60, 2); if(jz(0x1016_9b6d, 0xb)) goto l_0x1016_9b6d; /* jz 0x10169b6d */
            ii(0x1016_9b62, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_9b64, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_9b68, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1016_9b6a, 3); call_abs(memd[ds, edx + 0x8]);          /* call dword [edx+0x8] */
        l_0x1016_9b6d:
            ii(0x1016_9b6d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9b72, 2); jmp(0x1016_9b86, 0x12); goto l_0x1016_9b86; /* jmp 0x10169b86 */
        l_0x1016_9b74:
            ii(0x1016_9b74, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_9b78, 4); test(memb[ds, eax + 0x6], 0x2);         /* test byte [eax+0x6], 0x2 */
            ii(0x1016_9b7c, 2); if(jnz(0x1016_9b84, 0x6)) goto l_0x1016_9b84; /* jnz 0x10169b84 */
            ii(0x1016_9b7e, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_9b81, 3); inc(memd[ds, eax + 0x4]);               /* inc dword [eax+0x4] */
        l_0x1016_9b84:
            ii(0x1016_9b84, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_9b86:
            ii(0x1016_9b86, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_9b89, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_9b8a, 1); pop(edi);                               /* pop edi */
            ii(0x1016_9b8b, 1); pop(esi);                               /* pop esi */
            ii(0x1016_9b8c, 1); pop(edx);                               /* pop edx */
            ii(0x1016_9b8d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_9b8e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_9b8f, 1); ret();                                  /* ret */
        }
    }
}
