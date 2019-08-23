using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_addc-edbe7bb3")]
        public void /* sys */ Method_1016_addc()
        {
            ii(0x1016_addc, 1); push(esi);                              /* push esi */
            ii(0x1016_addd, 1); push(edi);                              /* push edi */
            ii(0x1016_adde, 1); push(ebp);                              /* push ebp */
            ii(0x1016_addf, 3); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1016_ade2, 4); mov(ebp, memd[ss, esp + 0x3c]);         /* mov ebp, [esp+0x3c] */
            ii(0x1016_ade6, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1016_adea, 4); mov(memd[ss, esp + 0x18], edx);         /* mov [esp+0x18], edx */
            ii(0x1016_adee, 4); mov(memd[ss, esp + 0x8], ebx);          /* mov [esp+0x8], ebx */
            ii(0x1016_adf2, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_adf5, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1016_adf9, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x1016_adfc, 5); mov(memw[ss, esp + 0x20], dx);          /* mov [esp+0x20], dx */
            ii(0x1016_ae01, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1016_ae05, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1016_ae08, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_ae0a, 4); mov(memd[ss, esp + 0x38], edx);         /* mov [esp+0x38], edx */
            ii(0x1016_ae0e, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x1016_ae11, 4); mov(esi, memd[ss, esp + 0x1e]);         /* mov esi, [esp+0x1e] */
            ii(0x1016_ae15, 5); mov(memw[ss, esp + 0x24], dx);          /* mov [esp+0x24], dx */
            ii(0x1016_ae1a, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_ae1c, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1016_ae1f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_ae22, 2); idiv(esi);                              /* idiv esi */
            ii(0x1016_ae24, 4); mov(edi, memd[ss, esp + 0x22]);         /* mov edi, [esp+0x22] */
            ii(0x1016_ae28, 4); mov(eax, memd[ss, esp + 0x40]);         /* mov eax, [esp+0x40] */
            ii(0x1016_ae2c, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_ae2e, 4); mov(memd[ss, esp + 0x4], edx);          /* mov [esp+0x4], edx */
            ii(0x1016_ae32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_ae34, 3); sar(edi, 0x10);                         /* sar edi, 0x10 */
            ii(0x1016_ae37, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_ae3a, 2); idiv(edi);                              /* idiv edi */
            ii(0x1016_ae3c, 3); imul(esi, edx);                         /* imul esi, edx */
            ii(0x1016_ae3f, 4); mov(ecx, memd[ss, esp + 0x38]);         /* mov ecx, [esp+0x38] */
            ii(0x1016_ae43, 3); add(ecx, 0x2);                          /* add ecx, 0x2 */
            ii(0x1016_ae46, 4); mov(memd[ss, esp + 0x38], ecx);         /* mov [esp+0x38], ecx */
            ii(0x1016_ae4a, 4); mov(memd[ss, esp + 0x40], edx);         /* mov [esp+0x40], edx */
            ii(0x1016_ae4e, 3); lea(edx, ecx + esi);                    /* lea edx, [ecx+esi] */
            ii(0x1016_ae51, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_ae53, 4); mov(memd[ss, esp + 0x14], edx);         /* mov [esp+0x14], edx */
            ii(0x1016_ae57, 4); mov(memd[ss, esp + 0xc], esi);          /* mov [esp+0xc], esi */
            ii(0x1016_ae5b, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_ae5d, 6); if(jle(0x1016_af38, 0xd5)) goto l_0x1016_af38; /* jle 0x1016af38 */
        l_0x1016_ae63:
            ii(0x1016_ae63, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_ae65, 4); mov(esi, memd[ss, esp + 0x18]);         /* mov esi, [esp+0x18] */
            ii(0x1016_ae69, 4); mov(memd[ss, esp + 0x1c], ecx);         /* mov [esp+0x1c], ecx */
            ii(0x1016_ae6d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_ae6f, 2); if(jle(0x1016_aedd, 0x6c)) goto l_0x1016_aedd; /* jle 0x1016aedd */
        l_0x1016_ae71:
            ii(0x1016_ae71, 4); mov(edx, memd[ss, esp + 0x1e]);         /* mov edx, [esp+0x1e] */
            ii(0x1016_ae75, 4); mov(esi, memd[ss, esp + 0x18]);         /* mov esi, [esp+0x18] */
            ii(0x1016_ae79, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1016_ae7d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_ae80, 2); sub(esi, ebx);                          /* sub esi, ebx */
            ii(0x1016_ae82, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1016_ae84, 2); cmp(esi, edx);                          /* cmp esi, edx */
            ii(0x1016_ae86, 2); if(jge(0x1016_ae8a, 0x2)) goto l_0x1016_ae8a; /* jge 0x1016ae8a */
            ii(0x1016_ae88, 2); mov(edx, esi);                          /* mov edx, esi */
        l_0x1016_ae8a:
            ii(0x1016_ae8a, 4); mov(esi, memd[ss, esp + 0x14]);         /* mov esi, [esp+0x14] */
            ii(0x1016_ae8e, 4); mov(edi, memd[ss, esp + 0x10]);         /* mov edi, [esp+0x10] */
            ii(0x1016_ae92, 4); mov(ecx, memd[ss, esp + 0x1c]);         /* mov ecx, [esp+0x1c] */
            ii(0x1016_ae96, 2); add(esi, ebp);                          /* add esi, ebp */
            ii(0x1016_ae98, 2); add(edi, ecx);                          /* add edi, ecx */
            ii(0x1016_ae9a, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_ae9c, 1); push(edi);                              /* push edi */
            ii(0x1016_ae9d, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_ae9f, 3); and(ebx, 0x3);                          /* and ebx, 0x3 */
            ii(0x1016_aea2, 6); test(ecx, 0xffff_fffc);                 /* test ecx, 0xfffffffc */
            ii(0x1016_aea8, 2); if(jz(0x1016_aeaf, 0x5)) goto l_0x1016_aeaf; /* jz 0x1016aeaf */
            ii(0x1016_aeaa, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1016_aead, 2); rep(() => movsd());                     /* rep movsd */
        l_0x1016_aeaf:
            ii(0x1016_aeaf, 6); test(ebx, 0x7);                         /* test ebx, 0x7 */
            ii(0x1016_aeb5, 2); if(jz(0x1016_aebb, 0x4)) goto l_0x1016_aebb; /* jz 0x1016aebb */
            ii(0x1016_aeb7, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_aeb9, 2); rep(() => movsb());                     /* rep movsb */
        l_0x1016_aebb:
            ii(0x1016_aebb, 1); pop(edi);                               /* pop edi */
            ii(0x1016_aebc, 4); mov(esi, memd[ss, esp + 0x1e]);         /* mov esi, [esp+0x1e] */
            ii(0x1016_aec0, 2); add(ebp, edx);                          /* add ebp, edx */
            ii(0x1016_aec2, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1016_aec5, 2); cmp(ebp, esi);                          /* cmp ebp, esi */
            ii(0x1016_aec7, 2); if(jnz(0x1016_aecb, 0x2)) goto l_0x1016_aecb; /* jnz 0x1016aecb */
            ii(0x1016_aec9, 2); xor(ebp, esi);                          /* xor ebp, esi */
        l_0x1016_aecb:
            ii(0x1016_aecb, 4); mov(edi, memd[ss, esp + 0x1c]);         /* mov edi, [esp+0x1c] */
            ii(0x1016_aecf, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1016_aed1, 4); mov(eax, memd[ss, esp + 0x18]);         /* mov eax, [esp+0x18] */
            ii(0x1016_aed5, 4); mov(memd[ss, esp + 0x1c], edi);         /* mov [esp+0x1c], edi */
            ii(0x1016_aed9, 2); cmp(edi, eax);                          /* cmp edi, eax */
            ii(0x1016_aedb, 2); if(jl(0x1016_ae71, -0x6c)) goto l_0x1016_ae71; /* jl 0x1016ae71 */
        l_0x1016_aedd:
            ii(0x1016_aedd, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1016_aee0, 4); mov(ebx, memd[ss, esp + 0x10]);         /* mov ebx, [esp+0x10] */
            ii(0x1016_aee4, 4); mov(ecx, memd[ss, esp + 0x40]);         /* mov ecx, [esp+0x40] */
            ii(0x1016_aee8, 4); mov(ebp, memd[ss, esp + 0x4]);          /* mov ebp, [esp+0x4] */
            ii(0x1016_aeec, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_aeed, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1016_aeef, 4); mov(edx, memd[ss, esp + 0x22]);         /* mov edx, [esp+0x22] */
            ii(0x1016_aef3, 4); mov(memd[ss, esp + 0x10], ebx);         /* mov [esp+0x10], ebx */
            ii(0x1016_aef7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_aefa, 4); mov(memd[ss, esp + 0x40], ecx);         /* mov [esp+0x40], ecx */
            ii(0x1016_aefe, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1016_af00, 2); if(jnz(0x1016_af12, 0x10)) goto l_0x1016_af12; /* jnz 0x1016af12 */
            ii(0x1016_af02, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_af04, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1016_af08, 4); mov(memd[ss, esp + 0x40], eax);         /* mov [esp+0x40], eax */
            ii(0x1016_af0c, 4); mov(memd[ss, esp + 0x14], edx);         /* mov [esp+0x14], edx */
            ii(0x1016_af10, 2); jmp(0x1016_af23, 0x11); goto l_0x1016_af23; /* jmp 0x1016af23 */
        l_0x1016_af12:
            ii(0x1016_af12, 4); mov(edx, memd[ss, esp + 0x1e]);         /* mov edx, [esp+0x1e] */
            ii(0x1016_af16, 4); mov(edi, memd[ss, esp + 0x14]);         /* mov edi, [esp+0x14] */
            ii(0x1016_af1a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_af1d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1016_af1f, 4); mov(memd[ss, esp + 0x14], edi);         /* mov [esp+0x14], edi */
        l_0x1016_af23:
            ii(0x1016_af23, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1016_af27, 1); inc(eax);                               /* inc eax */
            ii(0x1016_af28, 4); mov(ebx, memd[ss, esp + 0x8]);          /* mov ebx, [esp+0x8] */
            ii(0x1016_af2c, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1016_af30, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_af32, 6); if(jl(0x1016_ae63, -0xd5)) goto l_0x1016_ae63; /* jl 0x1016ae63 */
        l_0x1016_af38:
            ii(0x1016_af38, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1016_af3b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_af3c, 1); pop(edi);                               /* pop edi */
            ii(0x1016_af3d, 1); pop(esi);                               /* pop esi */
            ii(0x1016_af3e, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
